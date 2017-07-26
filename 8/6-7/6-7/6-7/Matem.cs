using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7
{
   static class Matem
    {
        //vyvid masyva
        public static void Info(int[] a)
        {
            foreach (int s in a)
            {
                Console.WriteLine($"{s}");
            }
        }
        public static void Max(int[] a)
        {
            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

            }
            Console.WriteLine($"Максимальне значення= {max}");

        }
    }
}
