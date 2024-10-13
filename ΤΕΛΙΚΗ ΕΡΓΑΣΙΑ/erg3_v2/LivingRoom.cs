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
    public partial class LivingRoom : Form
    {
        public LivingRoom()
        {
            InitializeComponent();
        }

        int aircon2 = 25;
        int x2 = 0;
        int x3 = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = aircon2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aircon2 += 1;
            label2.Text = aircon2.ToString();
            if (aircon2 >= 30)
            {
                MessageBox.Show("Max temperature is 30");
                aircon2 = 30;
                label2.Text = aircon2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aircon2 -= 1;
            label2.Text = aircon2.ToString();
            if (aircon2 <= 10)
            {
                MessageBox.Show("Min temperature is 10");
                aircon2 = 10;
                label2.Text = aircon2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "OFF";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x2++;
            if (x2 == 1)
            {
                label6.ImageIndex = x2;
            }
            x2 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x2 == 0)
            {
                label6.ImageIndex = x2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (x3 == 0)
            {
                label9.ImageIndex = x3;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x3++;
            if (x3 == 1)
            {
                label9.ImageIndex = x3;
            }
            x3 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το τζάκι άναψε");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το τζάκι εσβησε");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form d = new devices();
            d.Show();
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new menu();
            m.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Διαχειριστείτε τις ηλεκτρονικές συσκευές που βρίσκονται στο σαλόνι σας με την βοήθεια των κουμπιών ON/OFF." + "\n" 
                + "Μπορείτε να ρυθμίσετε την θερμοκράσια του χώρου,αυξάνοντας την θερμοκρασία με το κουμπι συν(+) ή μειωνοντάς την με το κουμπι πλην(-) " + "\n"
                + "Πατώντας το κουμπί Μenu επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Πατώντας το κουμπι BACK επιστρέφετε στο μενού διαχειρίσης συσκεύων");

        }
    }
}

