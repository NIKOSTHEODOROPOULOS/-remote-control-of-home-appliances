using ergasia3check;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erg3_v2
{
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο καφές σας είναι έτοιμος!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Κλείσιμο καφετιέρας");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληντύριο πιάτων: Σε λειτουργία");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληντύριο πιάτων: Εκτός λειτουργίας");
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new menu();
            m.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form d = new devices();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διαχειριστείτε τις ηλεκτορικές συσκευές σας με την βοήθεια των κουμπιών ON/OFF."+"\n"
                + "Πατώντας το κουμπί ΜENU επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Πατώντας το κουμπι BACK επιστρέφετε στο μενού διαχειρίσης συσκεύων");
        }
    }
}
