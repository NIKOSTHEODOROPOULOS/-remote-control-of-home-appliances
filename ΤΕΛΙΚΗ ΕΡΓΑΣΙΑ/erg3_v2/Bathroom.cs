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
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Θερμοσίφωνας: Ανοιχτός \n" +
                " θα έχετε ζεστό νερό σε 20 λεπτά");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Θερμοσίφωνας: κλειστός");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληντύριο σε λειτουργία");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληντύριο εκτός λειτουργίας");
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
            MessageBox.Show("Διαχειριστείτε τις ηλεκτρονικές συσκευές σας με την βοήθεια των κουμπιών ON/OFF. " + "\n"
                + "Πατώντας το κουμπί ΜENU επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Πατώντας το κουμπι BACK επιστρέφετε στο μενού διαχειρίσης συσκεύων");
        }
    }
}
