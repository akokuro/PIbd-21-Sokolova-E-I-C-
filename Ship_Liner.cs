using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class Ship_Liner : Ship
    {
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipWidth = 100;
        /// <summary>
        /// Ширина отрисовки коробля
        /// </summary>
        private const int shipHeight = 60;
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
        public Ship_Liner(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       pipe, bool smokeFromPipe, bool window) :
 base(maxSpeed, weight, mainColor)

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
            // отрисуем сперва трубу
            if (Pipe)
            {
                Brush pipe = new SolidBrush(MainColor);
                g.FillRectangle(pipe, _startPosX + 60, _startPosY - 50, 10, 15);
            }
            // и дым
            if (SmokeFromPipe)
            {
                Brush smoke = new SolidBrush(Color.Gray);
                g.FillEllipse(smoke, _startPosX + 57, _startPosY - 47, 2, 2);
                g.FillEllipse(smoke, _startPosX + 52, _startPosY - 44, 3, 3);
                g.FillEllipse(smoke, _startPosX + 43, _startPosY - 42, 5, 5);
            }
            // теперь отрисуем основную часть корабля
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX + 80, _startPosY);
            g.DrawLine(pen, _startPosX + 10, _startPosY, _startPosX, _startPosY - 25);
            g.DrawLine(pen, _startPosX + 80, _startPosY, _startPosX + 90, _startPosY - 25);
            g.DrawLine(pen, _startPosX, _startPosY - 25, _startPosX + 90, _startPosY - 25);
            g.DrawLine(new Pen(Color.Red), _startPosX + 5, _startPosY - 13, _startPosX + 85, _startPosY - 13);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 35, 70, 10);

            // рисуем окна лайнера
            if (Window)
            {
                Brush spoiler = new SolidBrush(DopColor);
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
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
