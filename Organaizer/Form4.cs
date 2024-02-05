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
    public partial class Form4 : Form
    {

        public event Action<EventS> Event;

        public Form4()
        {
            InitializeComponent();
            cmbE.Items.AddRange(new[] { "☘︎", "🕷", "★" });
        }

        public class EventS
        {
            public string NameE { get; set; }
            public DateTime DateE { get; set; }
            public string Ebox { get; set; }
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
            EventS events = new EventS
            {
                NameE = txtN.Text,
                Ebox = cmbE.SelectedItem?.ToString(),
                DateE = MounthCalendar.SelectionStart.Date + Time.Value.TimeOfDay
            };
            Event?.Invoke(events);
        }
    }
}
