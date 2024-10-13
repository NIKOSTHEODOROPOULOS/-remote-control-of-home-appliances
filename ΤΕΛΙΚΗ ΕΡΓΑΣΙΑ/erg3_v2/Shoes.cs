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
    public partial class Shoes : Form
    {
        public Shoes()
        {
            InitializeComponent();
        }

       

        private void MENU_Click(object sender, EventArgs e)
        {
            Hide();
            Form m = new menu();
            m.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            int act = activities.SelectedIndex;
           

                if (act == 0)
                {
                    label2.ImageList = formal;
                }
                else if (act == 1)
                {
                    label2.ImageList = casual;
                }
                else if (act == 2)
                {
                    label2.ImageList = formal;
                }
                else if (act == 3)
                {
                    label2.ImageList = formal;
                }
                else if (act == 4)
                {
                    label2.ImageList = casual;
                }
                else if (act == 5)
                {
                    label2.ImageList = casual;
                }
                else if (act == 6)
                {
                    label2.ImageList = sports;
                }
                else if (act == 7)
                {
                    label2.ImageList = all;
                }
            }

        
        int x = 0;
        private void button17_Click(object sender, EventArgs e)
        {
            x++;
            Random s = new Random();
            int x1 = s.Next(1, 9);
            label2.ImageIndex = x1;
            if (x == 5)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "ΘΕΛΕΤΕ ΝΑ ΔΕΙΤΕ ΣΕ ΗΛΕΚΤΡΟΝΙΚΟ ΚΑΤΑΣΤΗΜΑ;", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.skroutz.gr/search?keyphrase=%CF%80%CE%B1%CF%80%CE%BF%CF%85%CF%84%CF%83%CE%B9%CE%B1&from=autocomplete");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Random s2 = new Random();
                    int x2 = s2.Next(1, 9);
                    label2.ImageIndex = x2;
                    x = 1;
                    x++;
                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eπιλέγετε την δραστηριότητα που θελετε να κάνετε απο την αναδυόμενη λιστα."+"\n"
                + "Πατώντας το κουμπί(ΔΕΙΤΕ ΤΗΝ ΠΡΟΤΑΣΗ)ο έξυπνος βοηθός σας προτείνει  το καταλληλο ζευγάρι παπούτσια μέσα από την παπουτσοθήκη σας" + "\n"
                +"ΤΟ κουμπι(CHANGE SHOE) δίνει την δυνατότητα στον χρήστη να δει και άλλες επιλόγες και αν δεν τον ικανοποιοόν οι προτάσεις παραπέμπει σε ηλεκτρονικό κατάστημα"+"\n"
                 +"Το κόκκινο κουμπί(Χ) κλείνει την εφαρμογή");
        }

        private void Shoes_Load(object sender, EventArgs e)
        {
            int ac1 = plan.shoes;
            if (ac1 > -1)
            {
                string[] activities = { "work", "school", "restaurant-food", "club", "walk", "gym", "coaching school", "other activity" };
                
                MessageBox.Show("Θα δείτε πρόταση για:"+activities[ac1]);
            
                if (ac1 == 0)
                {
                    label2.ImageList = formal;
                }
                else if (ac1 == 1)
                {
                    label2.ImageList = casual;
                }
                else if (ac1 == 2)
                {
                    label2.ImageList = formal;
                }
                else if (ac1 == 3)
                {
                    label2.ImageList = formal;
                }
                else if (ac1 == 4)
                {
                    label2.ImageList = casual;
                }
                else if (ac1 == 5)
                {
                    label2.ImageList = casual;
                }
                else if (ac1 == 6)
                {
                    label2.ImageList = sports;
                }
                else if (ac1 == 7)
                {
                    label2.ImageList = all;
                }
            }
        }
    }
}

