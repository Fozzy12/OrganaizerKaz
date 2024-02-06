using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Organaizer.Form4;

namespace Organaizer
{
    public partial class Form2 : Form
    {
        // Создание пустого списка событий
        private List<EventS> eventsList = new List<EventS>();

        public Form2()
        {
            InitializeComponent();
            // Добавляем обработчик события изменения выбранного элемента в cmbM
            cmbM.SelectedIndexChanged += StatusFilter;
            // Добавляем обработчики событий изменения выбранного значения в rb1 и rb2
            rb1.CheckedChanged += rb1_CheckedChanged;
            rb2.CheckedChanged += rb1_CheckedChanged;
            // Скрываем элемент cmbM
            cmbM.Visible = false;
            // Выбираем по умолчанию rb2
            rb2.Checked = true;
        }

        private void StatusFilter(object sender, EventArgs e)
        {
            // Вызываем метод DataUpgrade
            DataUpgrade();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Вызываем метод AddForm(), который возвращает объект типа Form4.EventS
            Form4.EventS eventData = AddForm();
            // Добавляем полученный объект eventData в список eventsList
            eventsList.Add(eventData);
            // Вызываем метод DataUpgrade() для обновления данных
            DataUpgrade();
        }

        private void DataUpgrade()
        {
            //Происходит очистка всех строк в таблице
            EventsBox.Rows.Clear();
            //Для каждого элемента eventData из отфильтрованного списка FilterE() происходит добавление строки в таблицу с данными: Ebox, DateE, NameE.
            foreach (var eventData in FilterE())
            {
                EventsBox.Rows.Add(eventData.Ebox, eventData.DateE.Date.ToString("d"), eventData.DateE.TimeOfDay.ToString(@"hh\:mm"), eventData.NameE);
            }
            // Если cmbM видим, то очищаем его элементы и добавляем в него элементы из списка StatuseE().
            if (cmbM.Visible)
            {
                cmbM.Items.Clear();
                cmbM.Items.AddRange(StatuseE().ToArray());
            }
        }

        private List<string> StatuseE()
        {
            List<string> unStatus = new List<string>();
            // Для каждого элемента eventData в списке eventsList проверяем, что значение поля Ebox не содержится в списке unStatus
            foreach (var eventData in eventsList)
            {
                // Если значение поля Ebox отсутствует в списке unStatus, то добавляем это значение в список
                if (!unStatus.Contains(eventData.Ebox))
                {
                    unStatus.Add(eventData.Ebox);
                }
            }
            return unStatus;
        }

        // Метод для получения данных о событии из формы Form4
        private Form4.EventS AddForm()
        {
            // Создаем экземпляр формы Form4
            Form4 AddEForm = new Form4();
            // Открываем форму
            AddEForm.ShowDialog();
            // Возвращаем объект типа form4.events
            return new Form4.EventS
            {
                // Присваиваем значения свойствам объекта form4.events
                NameE = AddEForm.NameE(),
                Ebox = AddEForm.Ebox(),
                DateE = AddEForm.DateE()
            };
        }

        private IEnumerable<Form4.EventS> FilterE()
        {
            // Если выбран rb1
            if (rb1.Checked)
            {
                // Получаем выбранный статус из cmbM
                string selectedStatus = cmbM.SelectedItem?.ToString() ?? string.Empty;
                // Возвращаем отфильтрованный список событий согласно выбранному статусу
                return eventsList.FindAll(eventData => eventData.Ebox == selectedStatus);
            }
            else
            {
                // Возвращаем полный список событий, если rb1 не выбран
                return eventsList;
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            // Показать выпадающий список cmbM, если rb1 выбран
            cmbM.Visible = rb1.Checked;
            // Выполнить обновление данных
            DataUpgrade();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
