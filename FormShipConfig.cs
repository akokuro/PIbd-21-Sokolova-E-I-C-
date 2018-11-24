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
    public partial class FormShipConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный корабль
        /// </summary>
        IShip ship = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event shipDelegate eventAddShip;

        public bool can = false;

        public FormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать корабль
        /// </summary>
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxConfig.Width, pictureBoxConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(50, 100, pictureBoxConfig.Width, pictureBoxConfig.Height);
                ship.DrawShip(gr);
                pictureBoxConfig.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на labelShip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Labe2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelLiner_MouseDown(object sender, MouseEventArgs e)
        {
            labelLiner.DoDragDrop(labelLiner.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship(100, 500, Color.Black);
                    break;
                case "Лайнер":
                    ship = new Ship_Liner(100, 500, Color.Blue, Color.Black, true, true,
                   true);
                    break;
            }
            DrawShip();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Ship_Liner)
                {
                    (ship as Ship_Liner).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
