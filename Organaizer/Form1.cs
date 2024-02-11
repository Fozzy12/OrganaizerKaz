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
    public partial class Form1 : Form
    {
        private bool rocketLaunched;
        private int rocketHeight;

        public Form1()
        {
            InitializeComponent();
            rocketLaunched = false;
            rocketHeight = 0;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            rocketLaunched = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rocketHeight += 10;
            if (rocketHeight >= this.Height)
            {
                timer1.Stop();
                rocketLaunched = false;
                rocketHeight = 0;
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (rocketLaunched)
            {
            e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(this.Width / 2 - 30, this.Height - rocketHeight, 60, 100));
            e.Graphics.FillPolygon(Brushes.Red, new Point[] { new Point(this.Width / 2, this.Height - rocketHeight - 100), new Point(this.Width / 2 + 30, this.Height - rocketHeight - 0), new Point(this.Width / 2 - 30, this.Height - rocketHeight - 0) });
            }

        }
    }
}
