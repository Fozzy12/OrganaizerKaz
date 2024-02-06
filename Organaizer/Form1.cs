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
        // Метод для инициализации подсказок
        private void InitializeTooltips()
        {
            // Создание объекта для подсказки для текстового поля txtL
            loginToolTip = new ToolTip();
            // Установка текста подсказки для поля txtL
            loginToolTip.SetToolTip(txtL, "Введите ваш логин!");
            // Создание объекта для подсказки для текстового поля txtP
            passwordToolTip = new ToolTip();
            // Установка текста подсказки для поля txtP
            passwordToolTip.SetToolTip(txtP, "Введите ваш пароль!");
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Отключение использования звездочек в поле ввода пароля
            txtP.UseSystemPasswordChar = false;
            // Если флажок выбран
            if (checkShow.Checked)
            {
                // Отображение текста в поле ввода пароля в виде обычного текста
                txtP.UseSystemPasswordChar = false;
            }
            else
            {
                // Отображение текста в поле ввода пароля в виде звездочек
                txtP.UseSystemPasswordChar = true;
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
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
            return username == "Kazanbaev" && password == "qwerty1234";
        }
    }
}
