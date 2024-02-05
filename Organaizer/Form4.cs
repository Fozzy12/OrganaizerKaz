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
    public partial class Form4 : Form
    {

        public event Action<Events> Event;

        public Form4()
        {
            InitializeComponent();
        }

        public class Events
        {
            public string NameE { get; set; }
            public DateTime Ebox { get; set; }
            public string DateE { get; set; }

        }

        public string NameE()
        {
            return txtN.Text;
        }

        public string Ebox()
        {
            return cmbE.SelectedItem?.ToString();
        }

        public DateTime DateE()
        {
            return MounthCalendar.SelectionStart.Date + Time.Value.TimeOfDay;
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            Events events = new Events
            {
                NameE = txtN.Text,
                Ebox = cmbE.SelectedItem?.ToString(),
                DateE = MounthCalendar.SelectionStart.Date + Time.Value.TimeOfDay
            };
            // Вызов добавления события и передача данных
            Event?.Invoke(events);
        }
    }
}
