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
    public partial class Live : Form
    {
        public Live()
        {
            InitializeComponent();
        }

        private void MENU_Click(object sender, EventArgs e)
        {
                 this.Hide();
                 Form m = new menu();
                 m.Show();
        }
         

        private void timerA1_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 1;
        }

        private void timerA2_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 2;
        }

        

        private void timerA0_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 0;
        }

        private void timerA3_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 3;
        }

        private void timerA4_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 4;
        }

        private void timerA5_Tick(object sender, EventArgs e)
        {
            label1.ImageIndex = 5;
        }
        int sumTime = 18;
        private void timer_Tick(object sender, EventArgs e)
        {
            int i = sumTime;
            while (i > 0)
            {

                if (i >= (sumTime - 3))
                {
                    label1.ImageIndex = 5;
                    i--;
                }
                else if ((i < sumTime - 3) && (i >= sumTime - 6))
                {
                    label1.ImageIndex = 4;
                    i--;
                }
                else if (i < (sumTime - 6) && (i >= sumTime - 9))
                {
                    label1.ImageIndex = 3;
                    i--;
                }
                else if (i < (sumTime - 9) && (i >= sumTime - 12))
                {
                    label1.ImageIndex = 2;
                    i--;
                }
                else if (i < (sumTime - 12) && (i >= sumTime - 15))
                {
                    label1.ImageIndex = 1;
                    i--;
                }
                else if (i < (sumTime - 15) && (i >= sumTime - 18))
                {
                    label1.ImageIndex = 0;
                    i--;
                }
                
            }
            sumTime--;
            
        }

        private void Live_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form p = new pet();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακολουθείτε σε live μετάδοση το κατοικίδιο σας." +"\n"
                +"Πατώντας το κουμπι MENU επιστρέφετε στο κεντρικό μενού" +"\n"
                +"Πατώντας το κουμπι BACK επιστρέφετε στην προηγούμενη σελίδα με τις υπόλοιπες επιλόγες για τα κατοικίδια σας");

        }
    }
}
