using ergasia3check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erg3_v2
{
    class daysacts
    {
        internal static string act()


        {
            int startime = plan.check1;
            int finisshtime = plan.check2;
            int d = plan.check5;

            int act1 = plan.check6;
            string[] dayys = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] hours1 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "0" };
            string[] activities = { "work", "school", "restaurant-food", "club", "walk", "gym", "coaching school", "other activity" };

            string acts = "ΗΜΕΡΑ:"+ dayys[d] +"\n "
               + "ΑΠΟ  " + hours1[startime] + " :00 "+"\n" 
               + " ΕΩΣ " + hours1[finisshtime] + " :00  "+"\n"
               + activities[act1];
            return acts;

        }
    }
}
