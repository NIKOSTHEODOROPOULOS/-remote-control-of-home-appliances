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
    public partial class pet : Form
    {
        public pet()
        {
            InitializeComponent();
        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Food fd = new Food();
            fd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Water w = new Water();
            w.Show();
        }

        private void pet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Live live = new Live();
            live.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε μία από τις παρακάτω ενέργειες για να δείτε live τα κατοικίδια σας(live video), να τα ταίσετε(Φαγητό), ή να τους δώσετε νερό(Νερό)."+"\n"
                + "Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή");
        }
    }
}
