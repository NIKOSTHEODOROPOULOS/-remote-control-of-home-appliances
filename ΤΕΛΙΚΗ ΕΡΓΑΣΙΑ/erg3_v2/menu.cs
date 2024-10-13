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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void planday_Click(object sender, EventArgs e)
        {
            this.Hide();
            plan f3 = new plan();
            f3.Show();

        }

        private void homedevices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f4 = new devices();
            f4.Show();
        }

        private void pets_Click(object sender, EventArgs e)
        {
            this.Hide();
            pet p1 = new pet();
            p1.Show();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλώς ήρθατε στο κεντρικό μενού της εφαρμoγής" + "\n"
                + "Υπαρχούν τρεις διαθέσιμες επιλογές να επιλεξέτε: " + "\n"
                + "+Να δημιουργήσετε το ημερησιο πλάνο σας,πατώντας στην επιλογή πλανο ήμερας" +"\n"
                + "+Να διαχειριστείτε απομακρυσμένα ηλεκτρικές συσκεύες του σπιτιού σας" + "\n" 
                + "+Να ελέγξετε την καταστασή των κατοικιδίων σας"+"\n"
                + "Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή"+"\n"
                + "Tο κουμπι αποσυνδεσης χρήστη(LOG OUT)");


        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
