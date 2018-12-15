using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormShip : Form
    {
        private IShip ship;

        public FormShip()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawShip(gr);
            pictureBoxShip.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(70, 170), pictureBoxShip.Width,
           pictureBoxShip.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateLiner_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship_Liner(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Gray, true, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(70, 170), pictureBoxShip.Width,
           pictureBoxShip.Height);
            Draw();
        }
    }
}
