using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public static class Binary_Hexi_Compare
    {
        public static bool process(string binary, string hexi)
        {
            int v1, v2;
            if (TryAnyBaseToDecimal(binary, 2, out v1) && TryAnyBaseToDecimal(hexi, 16, out v2))
            {
                if (v1 == v2)
                {
                    return true;
                }

            }
            return false;
        }

        private static bool TryAnyBaseToDecimal(string s, int baseValue, out int Value)
        {
            Value = 0;
            if (baseValue != 2 && baseValue != 16)
            {
                return false;
            }
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int digit = GetDigitFromChar(s[i]);
                if (digit < 0 || digit > baseValue)
                    return false;
                int exp = (s.Length - 1) - i;
                Value += digit * (int)Math.Pow(baseValue, exp);
            }
            return true;
        }

        private static int GetDigitFromChar(char v)
        {
            int val;
            v = char.ToLower(v);
            val = v-'0';
            switch (v)
            {
                case 'a':
                    val = 10;
                    break;
                case 'b':
                    val = 11;
                    break;
                case 'c':
                    val = 12;
                    break;
                case 'd':
                    val = 13;
                    break;
                case 'e':
                    val = 14;
                    break;
                case 'f':
                    val = 15;
                    break;

            }
            return val;
        }
    }
}
