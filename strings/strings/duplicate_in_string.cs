using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public static class duplicate_in_string
    {
        static int[] counter;
        public static void process(string input)
        {
            if( string.IsNullOrEmpty(input))
            {
                return;
            }
            //counter = new bool[256];
            counter = new int[256];
            foreach (var c in input)
            {
                counter[c]++;
            }

            foreach (var c in input)
            {
                if (counter[c] != 0)
                {
                    Console.WriteLine(string.Format("{0} - {1}", c, counter[c]));
                    counter[c] = 0;
                }

            }
        }
    }
}
