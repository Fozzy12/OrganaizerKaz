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

        private List<EventS> eventsList = new List<EventS>();

        public Form2()
        {
            InitializeComponent();
            cmbM.SelectedIndexChanged += StatusFilter;
            rb1.CheckedChanged += rb1_CheckedChanged;
            rb2.CheckedChanged += rb1_CheckedChanged;
            cmbM.Visible = false;
            rb1.Checked = true;
        }

        private void StatusFilter(object sender, EventArgs e)
        {
            DataUpgrade();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form4.EventS eventData = AddForm();
            eventsList.Add(eventData);
            DataUpgrade();
        }

        private void DataUpgrade()
        {
            EventsBox.Rows.Clear();

            foreach (var eventData in FilterE())
            {
                EventsBox.Rows.Add(eventData.Ebox, eventData.DateE.Date.ToString("d"), eventData.DateE.TimeOfDay.ToString(@"hh\:mm"), eventData.NameE);
            }

            if (cmbM.Visible)
            {
                cmbM.Items.Clear();
                cmbM.Items.AddRange(StatuseE().ToArray());
            }
        }

        private List<string> StatuseE()
        {
            List<string> uniqueStatuses = new List<string>();
            foreach (var eventData in eventsList)
            {
                if (!uniqueStatuses.Contains(eventData.Ebox))
                {
                    uniqueStatuses.Add(eventData.Ebox);
                }
            }
            return uniqueStatuses;
        }

        private Form4.EventS AddForm()
        {
            Form4 addEventForm = new Form4();
            addEventForm.ShowDialog();

            return new Form4.EventS
            {
                NameE = addEventForm.NameE(),
                Ebox = addEventForm.Ebox(),
                DateE = addEventForm.DateE()
            };
        }

        private IEnumerable<Form4.EventS> FilterE()
        {
            if (rb1.Checked)
            {
                string selectedStatus = cmbM.SelectedItem?.ToString() ?? string.Empty;
                return eventsList.FindAll(eventData => eventData.Ebox == selectedStatus);
            }
            else
            {
                return eventsList;
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            cmbM.Visible = rb1.Checked;
            DataUpgrade();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
