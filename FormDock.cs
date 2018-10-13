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
    public partial class FormDock : Form
    {
        /// <summary>
        /// Объект от класса-дока
        /// </summary>
        Dock<IShip> dock;

        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<IShip>(15, pictureBoxDock.Width,
pictureBoxDock.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Швартовать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                int place = dock + ship;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Швартовать лайнер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetLiner_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var liner = new Ship_Liner(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = dock + liner;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = dock - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(15, 60, pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    ship.DrawShip(gr);
                    pictureBoxTakeShip.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    pictureBoxTakeShip.Image = bmp;
                }
                Draw();
            }
        }
    }
}
