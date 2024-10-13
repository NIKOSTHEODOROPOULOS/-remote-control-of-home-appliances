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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        internal static string name;
        internal static string Pass;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sign_Click(object sender, EventArgs e)
        {
            name = Username.Text;
            Pass = Password.Text;
            if (name == "username1" && Pass == "pass1" || name == "username2" && Pass == "pass2")
            {
                MessageBox.Show("WELCOME");
                this.Hide();
                menu f2 = new menu();
                f2.Show();
            }


            else
            {
                MessageBox.Show("Δώστε σωστό όνομα χρήστη ή κωδικό");//δείτε το txt αρχείο που συνοδεύει την εργασία
            }
        }

        private void sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sign_up S = new sign_up();
            S.Show();
        }
    }
}
