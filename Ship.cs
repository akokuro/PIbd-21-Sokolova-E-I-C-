using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class Ship : Boat, IComparable<Ship>, IEquatable<Ship>
    {
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipWidth = 100;
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipHeight = 60;
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес коробля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="pipe">Признак наличия трубы</param>
        /// <param name="smokeFromPipe">Признак наличия дыма из трубы</param>
        /// <param name="window">Признак наличия окон</param>
        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка коробля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(MainColor);

            // теперь отрисуем основную часть корабля
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX + 80, _startPosY);
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX, _startPosY - 25);
            g.DrawLine(pen, _startPosX + 80, _startPosY, _startPosX + 90, _startPosY - 25);
            g.DrawLine(pen, _startPosX, _startPosY - 25, _startPosX + 90, _startPosY - 25);
            g.DrawLine(new Pen(Color.Red), _startPosX + 5, _startPosY - 13, _startPosX + 85, _startPosY - 13);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 35, 70, 10);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса Ship
        /// </summary>
        /// <param name="other"></
        public int CompareTo(Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Ship
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Ship shipObj = obj as Ship;
            if (shipObj == null)
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }/// <summary>
 /// Перегрузка метода от object
 /// </summary>
 /// <returns></returns>
 public override int GetHashCode()
 {
 return base.GetHashCode();
 }
    }
}
