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
using System.Linq.Expressions;
using Image = System.Drawing.Image;



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
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "PNG File(*.png)|*.png";
            if(savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch(strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff); break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png); break;
                    default:
                        break;
                }
            }

        }
    }
}
