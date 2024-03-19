using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Organaizer
{
    public partial class Form1 : Form
    {
        private Point PreviousPoint, point; private Bitmap bmp;
        private Pen blackPen; private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                Image image = Image.FromFile( dialog.FileName ); 
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width; 
                pictureBox1.Height = height;
                bmp = new Bitmap(image, width, height);
                pictureBox1.Image = bmp;
                g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point.X = e.X; 
                point.Y = e.Y;
                g.DrawLine(blackPen, PreviousPoint, point);
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
