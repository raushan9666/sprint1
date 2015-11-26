using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public static class Union_Intersection_3Array
    {
        public static void process()
        {
            int[] arr1 = { 1, 5, 10, 20, 40, 80 };
            int[] arr2 = { 6, 7, 20, 80, 100 };
            int[] arr3 = { 3, 4, 15, 20, 30, 70, 80, 120 };

            int[] union = new int[arr1.Length + arr2.Length + arr3.Length];
            int[] intersection = new int[arr3.Length];

            int x = 0, y = 0, z = 0, m = arr1.Length, n = 0;
            Array.Copy(arr1,union,arr1.Length);
            while (x < arr1.Length && y < arr2.Length && z < arr3.Length)
            {
                if (arr1[x] == arr2[y] && arr2[y] == arr3[z])
                {
                    intersection[n++] = arr1[x++];
                    y++; z++;
                }
               else if (arr1[x] < arr2[y])
                {
                    x++;
                }
                else if (arr2[y] < arr3[z])
                {
                    union[m++] = arr2[y++];
                }
                else
                {
                    union[m++] = arr3[z++];
                }
            }

            while(x<arr1.Length)
            {
                union[m++] = arr1[x++];
            }
            while(y<arr2.Length)
            {
                union[m++] = arr2[y++];
            }
            while(z<arr3.Length)
            {
                union[m++] = arr3[z++];
            }


            foreach (var item in intersection)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();
            foreach (var item in union)
            {
                Console.Write(item + " , ");
            }


        }
    }
}
