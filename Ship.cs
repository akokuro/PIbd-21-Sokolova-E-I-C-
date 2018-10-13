using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class Ship : Boat
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

    }
}
