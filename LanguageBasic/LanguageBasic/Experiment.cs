using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic
{
    class Experiment
    {
        internal static double total=0;
        //internal static double media=0;
        internal static int count=0;

        private double value;
        internal int intTest;

        public Experiment (double v, int i)
        {
            value = v;
            total += v;
            count++;
        } 

        public static double Media()
        {
            return total/count;
        }

        public int Plus10Test()
        {
            intTest += 10;
            return intTest + 10;
        }
    }
}
