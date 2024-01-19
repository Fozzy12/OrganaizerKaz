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
        private ToolTip loginToolTip;
        private ToolTip passwordToolTip;

        public Form1()
        {
            InitializeComponent();
            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            loginToolTip = new ToolTip();
            loginToolTip.SetToolTip(txtL, "Введите ваш логин!");

            passwordToolTip = new ToolTip();
            passwordToolTip.SetToolTip(txtP, "Введите ваш пароль!");
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtP.UseSystemPasswordChar = false;
            if (checkShow.Checked)
            {
                txtP.UseSystemPasswordChar = false;
            }
            else
            {
                txtP.UseSystemPasswordChar = true;
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {

        }
    }
}
