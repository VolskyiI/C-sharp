using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = ran.Next(1, 10);
                    if (i==j)
                    {
                        a[i, j] = 0;

                    }
                    Console.Write("{0}\t", a[i, j]);

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
