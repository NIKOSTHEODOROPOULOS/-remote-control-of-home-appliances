using System;
using erg3_v2;
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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }
        internal static string Pass;
        internal static string Pass2;
        internal static string Name2;
        private void sign_Click(object sender, EventArgs e)
        {
            Name2 = Username.Text;
            Pass = Password.Text;
            Pass2 = Password2.Text;
            if(Pass==""|| Pass2==""|| Name2=="")
            {
                MessageBox.Show("Δεν έχετε συμπληρώσει τα πεδία");
            }
            else if(Pass == Pass2)
            {
                MessageBox.Show("Η εγγραφή σας ολοκληρώθηκε");
                this.Hide();
                menu M = new menu();
                M.Show();

            }
            else
            {
                MessageBox.Show("Οι κωδικοί δεν ταυτίζονται");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η φόρμα εγγραφής." + "\n"
                + "Ο χρήστης συμπληρώνει το username του,τον κωδικό του και δημιουργεί τον λογαριασμό"+"\n"
                + "Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή");
        }
    }
}
