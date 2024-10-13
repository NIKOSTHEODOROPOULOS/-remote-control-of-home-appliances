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
    public partial class devices : Form
    {
        public devices()
        {
            InitializeComponent();
        }


        int indicator1 = 0;
        int indicator2 = 0;
        int indicator3 = 0;
        int indicator4 = 0;
        int indicator5 = 0;
        int indicator6 = 0;
        int temp = 20;

        private void button4_Click(object sender, EventArgs e)
        {
            indicator1++;
            if (indicator1 == 1)
            {
                label3.ImageIndex = indicator1;
            }
            indicator1 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (indicator1 == 0)
            {
                label3.ImageIndex = indicator1;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            indicator2++;
            if (indicator2 == 1)
            {
                label6.ImageIndex = indicator2;
            }
            indicator2 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (indicator2 == 0)
            {
                label6.ImageIndex = indicator2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            indicator3++;
            if (indicator3 == 1)
            {
                label8.ImageIndex = indicator3;
            }
            indicator3 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (indicator3 == 0)
            {
                label8.ImageIndex = indicator3;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            indicator4++;
            if (indicator4 == 1)
            {
                label10.ImageIndex = indicator4;
            }
            indicator4 = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (indicator4 == 0)
            {
                label10.ImageIndex = indicator4;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            indicator5++;
            if (indicator5 == 1)
            {
                label12.ImageIndex = indicator5;
            }
            indicator5 = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (indicator5 == 0)
            {
                label12.ImageIndex = indicator5;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (indicator6 == 0)
            {
                label14.ImageIndex = indicator6;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            indicator6++;
            if (indicator6 == 1)
            {
                label14.ImageIndex = indicator6;
            }
            indicator6 = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            indicator1++;
            indicator2++;
            indicator3++;
            indicator4++;
            indicator5++;
            if (indicator1 == 1 || indicator2 == 1 || indicator3 == 1 || indicator4 == 1 || indicator5 == 1)
            {
                label3.ImageIndex = indicator1;
                label6.ImageIndex = indicator2;
                label8.ImageIndex = indicator3;
                label10.ImageIndex = indicator4;
                label12.ImageIndex = indicator5;

            }
            indicator1 = 0;
            indicator2 = 0;
            indicator3 = 0;
            indicator4 = 0;
            indicator5 = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indicator1 == 0 || indicator2 == 0 || indicator3 == 0 || indicator4 == 0 || indicator5 == 0)
            {
                label3.ImageIndex = indicator1;
                label6.ImageIndex = indicator2;
                label8.ImageIndex = indicator3;
                label10.ImageIndex = indicator4;
                label12.ImageIndex = indicator5;

            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shoes f2 = new Shoes();
            f2.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            label16.Text = temp.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label16.Text = ("OFF");
        }



        private void button19_Click(object sender, EventArgs e)
        {
            temp += 1;
            label16.Text = temp.ToString();
            if (temp >= 30)
            {
                MessageBox.Show("Max temperature is 30");
                temp = 30;
                label16.Text = temp.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            temp -= 1;
            label16.Text = temp.ToString();
            if (temp <= 10)
            {
                MessageBox.Show("Min temperature 10");
                temp = 10;
                label16.Text = temp.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room1 r1 = new Room1();
            r1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room1 r1 = new Room1();
            r1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitchen k1 = new Kitchen();
            k1.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LivingRoom l1 = new LivingRoom();
            l1.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bathroom b1 = new Bathroom();
            b1.Show();
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new menu();
            m.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Με την βοήθεια των κεντρικών κουμπιών ON / OFF ,ελέγχετε τα φώτα σε όλο το σπίτι ,ενω σε κάθε χώρο ξεχώριστα με τα αντίστοιχα ON/OFF " + "\n"
                + "Πατώντας το κουμπί ΜENU επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Κάνοντας κλικ στον χώρο,είτε στην εικόνα είτε στην ονομασια(π.χ σαλόνι),εισέρχεστε σε αυτόν ωστε να διαχειριστείτε τις συσκευές που βρίσκονται μέσα σε αυτον" + "\n"
                + "Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή");
        }
    }
}
