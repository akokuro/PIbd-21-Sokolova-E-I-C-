using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса IShip
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Dock<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Dock<T>> where T : class, IShip
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Текущий элемент для вывода через IEnumerator 
        /// (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;

        /// <summary>
        /// Получить порядковое место на парковке
        /// </summary>
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }

        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private int _placeSizeHeight = 80;
        /// <summary>
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в доке</param>
        /// <param name="pictureWidth">Рамзер дока - ширина</param>
        /// <param name="pictureHeight">Рамзер дока - высота</param>
        public Dock(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в док добавляется корабль
        /// </summary>
        /// <param name="p">Док</param>
        /// <param name="ship">Добавляемый корабль</param>
        /// <returns></returns>
        public static int operator +(Dock<T> p, T ship)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new DockOverflowException();
            }
            if (p._places.ContainsValue(ship))
            {
                throw new DockAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, ship);
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
                     (i % 5 * p._placeSizeHeight + 15) + 50, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: из дока забираем корабль
        /// </summary>
        /// <param name="p">Док</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Dock<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places.Remove(index);
                return car;
            }
            throw new DockNotFoundException(index);
        }
        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        /// <summary>
        /// Метод отрисовки дока
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawShip(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }


        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 *
                    _placeSizeHeight + 57, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new DockOccupiedPlaceException(ind);
                }
            }
        }

        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
            _places.Clear();
        }

        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }

        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Dock<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Ship && other._places[thisKeys[i]] is
                   Ship_Liner)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Ship_Liner && other._places[thisKeys[i]] is
                    Ship)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Ship && other._places[thisKeys[i]] is Ship)
                    {
                        return (_places[thisKeys[i]] is
                       Ship).CompareTo(other._places[thisKeys[i]] is Ship);
                    }
                    if (_places[thisKeys[i]] is Ship_Liner && other._places[thisKeys[i]] is
                    Ship_Liner)
                    {
                        return (_places[thisKeys[i]] is
                       Ship_Liner).CompareTo(other._places[thisKeys[i]] is Ship_Liner);
                    }
                }
            }
            return 0;
        }

    }
}
