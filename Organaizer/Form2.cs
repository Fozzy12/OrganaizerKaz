using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organaizer
{
    public partial class Form2 : Form
    {
        // Это переменная указывает, была ли запущена ракета
        private bool rocketLaunched;
        // Это переменная хранит текущую высоту, на которой находится ракета
        private int rocketHeight;

        public Form2()
        {
            InitializeComponent();
            //Ракета не запущена.
            rocketLaunched = false;
            //Высота ракеты равна нулю
            rocketHeight = 0;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            //Запуск ракеты
            rocketLaunched = true;
            //Запуск таймера
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Увеличиваем высоту ракеты на 10
            rocketHeight += 10;
            // Проверяем, достигла ли ракета максимальной высоты
            if (rocketHeight >= this.Height)
            {
                // Если да, останавливаем таймер, устанавливаем флаг запуска ракеты на false и сбрасываем высоту
                timer1.Stop();
                rocketLaunched = false;
                rocketHeight = 0;
            }
            //Обновление отображения
            this.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (rocketLaunched)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(this.Width / 2 - 30, this.Height - rocketHeight, 60, 100));
                e.Graphics.FillPolygon(Brushes.Red, new Point[] { new Point(this.Width / 2, this.Height - rocketHeight - 100), new Point(this.Width / 2 + 30, this.Height - rocketHeight - 0), new Point(this.Width / 2 - 30, this.Height - rocketHeight - 0) });
            }
        }
    }
}
