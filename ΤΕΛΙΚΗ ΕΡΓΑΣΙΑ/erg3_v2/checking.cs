using ergasia3check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erg3_v2
{
    class checking//ελεγχος για ορθή καταχώρηση ώρας
    {
        internal static int Time()
        {
            int startime = plan.check1;
            int finisshtime = plan.check2;
            
            if ((startime == finisshtime ) || ( startime == -1 ))
            {
                int time = -1;
                return time;
            }
            if (finisshtime == -1 || finisshtime < startime)
            {
                int time = -2;
                return time;
            }    

            else
            {
                int time = 0;
                return time;
            }
        }
    }
}
