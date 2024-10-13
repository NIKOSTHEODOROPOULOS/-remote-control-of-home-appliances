using erg3_v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia3check
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new menu();
            m.Show();
        }
        int bowl1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            bowl1++;
            if (bowl1 == 1)
            {
                label1.ImageIndex = bowl1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form p = new pet();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πιέστε το κουμπί 'Τάισε' για να δώσετε τροφή στο κατοικίδιο σας."+"\n"
                + "Πατώντας το κουμπί ΜENU επιστρέφετε στο κεντρικό μενού  της εφαρμογής" + "\n"
                + "Πατώντας το κουμπι BACK επιστρέφετε στην προηγούμενη σελίδα με τις υπόλοιπες επιλόγες για τα κατοικίδια σας ");
        }
    }
}
