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
using System.IO;
using System.Xml.Serialization;

namespace erg3_v2
{
    public partial class plan : Form
    {
        public plan()
        {
            InitializeComponent();
        }

        int i = 0;
        internal static int check1;
        internal static int check2;
        internal static int check5;
        internal static int check6;
        internal static int shoes=-1;

        private void button1_Click(object sender, EventArgs e)

        {
            int checkf1 = starttime.SelectedIndex;
            int checkf2 = finishtime.SelectedIndex;
            int day = choosingday.SelectedIndex;
            int ac1 = activities.SelectedIndex;
            check1 = checkf1;
            check2 = checkf2;
            check5 = day;
            check6 = ac1;
            int error = checking.Time();
            if (day == -1)
            {
                MessageBox.Show("ERROR : DAY NO FOUND");
            }
            else
            {
                if ((error == -1 && day >= 0))
                {
                    MessageBox.Show("Έχετε δώσει λανθασμένη χρονική διάρκεια,η ώρα έναρξης ταυτίζεται με την ώρα λήξης ή έχετε κενό πεδίο");
                }
                else if (error == -2)
                {
                    MessageBox.Show("Έχετε δώσει λανθασμένη χρονική διάρκεια,η ώρα έναρξης είναι μεταγενέστερη απο την ώρα λήξης");
                }
                else if(ac1==-1)
                {
                    MessageBox.Show("Δεν έχετε δώσει δραστηριότητα");
                }    
                else
                {
                    MessageBox.Show("Η καταχώρηση πραγματοποιήθηκε");
                    i++;
                    DialogResult dialogResult = MessageBox.Show(
                    "ΘΕΛΕΤΕ ΝΑ ΔΕΙΤΕ ΚΑΤΑΛΛΗΛΟ ΖΕΥΓΑΡΙ ΠΑΠΟΥΤΙΣΩΝ;", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        shoes = ac1;
                        this.Hide();
                        Shoes s = new Shoes();
                        s.Show();
                        
                    }
                    /*string daysact = daysacts.act();
                    List<Act> daysactivity = new List<Act>();
                    daysactivity.Add(new Act());*/

                }

            }
        }
    
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new menu();
            m.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                string daysact = daysacts.act();
                MessageBox.Show(daysact);
            }
            else
            {
                MessageBox.Show ("Δεν έχετε καταχωρήσει τιποτα");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καταχωρήστε το πρόγραμμα σας συμπληρώνοντας την παρακάτω φόρμα." + "\n"
                + "ΔΙΑΛΕΞΕ ΗΜΕΡΑ:Σε αυτη την επιλογή ο χρήστης επιλέγει την ημέρα που θέλει να δημιουργήσει πλάνο" + "\n"
                + "ΩΡΑ ΕΝΑΡΞΗΣ:Καταχώρει ο χρήστης την ώρα που αρχίζει η δραστηριοτητά του " + "\n"
                + "ΩΡΑ ΛΗΞΗΣ:Καταχώρει ο χρήστης την ώρα που θα τελειώσει η δραστηριοτητά του" + "\n"
                + "ΔΡΑΣΤΗΡΙΟΤΗΤΑ:Ο χρήστης επιλέγει την δραστηρίοτητα που επιθυμεί να καταχωρήσει" + "\n"
                + "Πατώντας το κουμπι(Καταχώρηση) ο χρήστης καταχωρεί(αποθηκεύει) τις επιλογές του" + "\n"
                + "Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή");
        }

        private void plan_Load(object sender, EventArgs e)
        {

        }
    }
    
}

