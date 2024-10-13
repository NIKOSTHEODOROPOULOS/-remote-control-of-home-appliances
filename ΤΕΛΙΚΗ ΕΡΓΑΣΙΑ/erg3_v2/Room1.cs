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
    public partial class Room1 : Form
    {
        public Room1()
        {
            InitializeComponent();
        }

        int aircon1 = 25;
        int x1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = aircon1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aircon1 += 1;
            label2.Text = aircon1.ToString();
            if (aircon1 >= 30)
            {
                MessageBox.Show("Max temperature is 30");
                aircon1 = 30;
                label2.Text = aircon1.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aircon1 -= 1;
            label2.Text = aircon1.ToString();
            if (aircon1 <= 10)
            {
                MessageBox.Show("Min temperature is 10");
                aircon1 = 10;
                label2.Text = aircon1.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "OFF";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            x1++;
            if (x1 == 1)
            {
                label6.ImageIndex = x1;
            }
            x1 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x1 == 0)
            {
                label6.ImageIndex = x1;
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διαχειριστείτε τις ηλεκτρονικές συσκευές που βρίσκονται στο σαλόνι σας με την βοήθεια των κουμπιών ON/OFF." + "\n"
                + "Μπορείτε να ρυθμίσετε την θερμοκράσια του χώρου,αυξάνοντας την θερμοκρασία με το κουμπι συν(+) ή μειωνοντάς την με το κουμπι πλην(-) " + "\n"
                + "Πατώντας το κουμπί ΜENU επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Πατώντας το κουμπι BACK επιστρέφετε στο μενού διαχειρίσης συσκεύων");
        }
    }
}
