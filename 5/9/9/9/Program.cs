using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 8];
            int k = 0;
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    a[i, j] = ran.Next(1, 10);

                    Console.Write("{0}\t", a[i, j]);

                }

                Console.WriteLine();

            }
           
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (a[i, j]%2==0)
                        {
                            k++;

                        }
                    }       
            }
            Console.WriteLine($"Кількість парних елементів в масиві = {k}");
            
            
            Console.ReadLine();
        }
    }
}
