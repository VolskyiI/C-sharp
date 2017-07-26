using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            string k;
            Console.WriteLine("Введіть граничне значення");
            k = Console.ReadLine();
            n = int.Parse(k);
            for (int i = 1; i <= n; i++)
            {
                suma = i + suma;
                ;


            }
            Console.WriteLine("Сума чисел = {0}", suma);
            Console.ReadKey();
        }
    }
}
