using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class Ship
    {/// <summary>
     /// Левая координата отрисовки коробля
     /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки коробля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipWidth = 100;
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес коробля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия трубы
        /// </summary>
        public bool Pipe { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SmokeFromPipe { private set; get; }
        /// <summary>
        /// Признак наличия окон
        /// </summary>
        public bool Window { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес коробля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="pipe">Признак наличия трубы</param>
        /// <param name="smokeFromPipe">Признак наличия дыма из трубы</param>
        /// <param name="window">Признак наличия окон</param>
        public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       pipe, bool smokeFromPipe, bool window)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Pipe = pipe;
            SmokeFromPipe = smokeFromPipe;
            Window = window;
        }
        /// <summary>
        /// Установка позиции коробля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        public void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва трубу
            if (Pipe)
            {
                Brush spoiler = new SolidBrush(Color.RoyalBlue);
                g.FillRectangle(spoiler, _startPosX + 60, _startPosY - 50, 10, 15);
            }
            // и дым
            if (SmokeFromPipe)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillEllipse(spoiler, _startPosX + 57, _startPosY - 47, 2, 2);
                g.FillEllipse(spoiler, _startPosX + 52, _startPosY - 44, 3, 3);
                g.FillEllipse(spoiler, _startPosX + 43, _startPosY - 42, 5, 5);
            }
            // теперь отрисуем основную часть корабля
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX + 80, _startPosY);
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX, _startPosY - 25);
            g.DrawLine(pen, _startPosX + 80, _startPosY, _startPosX + 90, _startPosY - 25);
            g.DrawLine(pen, _startPosX, _startPosY - 25, _startPosX + 90, _startPosY - 25);
            g.DrawLine(new Pen(Color.Red), _startPosX + 5, _startPosY - 13, _startPosX + 85, _startPosY - 13);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 35, 70, 10);

            // рисуем задний спойлер автомобиля
            if (Window)
            {
                Brush spoiler = new SolidBrush(Color.Blue);
                g.FillEllipse(spoiler, _startPosX + 45, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 35, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 55, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 65, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 25, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 15, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 75, _startPosY - 23, 7, 7);
                g.FillEllipse(spoiler, _startPosX + 5, _startPosY - 23, 7, 7);
            }
        }

    }
}
