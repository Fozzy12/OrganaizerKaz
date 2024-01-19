﻿using System;
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
            // Проверка логина и пароля
            string username = txtL.Text;
            string password = txtP.Text;

            if (CheckCredentials(username, password))
            {
                Hide();
                Form2 btnB = new Form2();
                btnB.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
            }
        }
        private bool CheckCredentials(string username, string password)
        {
            // Проверка логина и пароля (здесь необходимо добавить вашу логику проверки)
            return username == "admin" && password == "admin123";
        }
    }
}
