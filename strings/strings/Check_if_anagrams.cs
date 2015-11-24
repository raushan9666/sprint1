using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public static class Check_if_anagrams
    {

        public static bool process(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            int[] counter = new int[256];
            if (s1 == null && s2 == null)
            {
                return true;
            }
            if (s1 != null && s2 != null && s1.Length == s2.Length)
            {
                // in case of s1 we increase the counter and in case if s2 we decrease the counter
                for (int i = 0; i < s1.Length; i++)
                {
                    counter[s1[i]]++;
                    counter[s2[i]]--;
                }

                for (int i = 0; i < 256; i++)
                {
                    if (counter[i] != 0)
                    {
                        return false;
                    }
                }
                return true;

            }
            return false;
        }
    }
}
