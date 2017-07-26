using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        { int i,k=0,suma=0;
            float serar;
            while (true)
            {
                Console.WriteLine("Введіть число");
               i=Convert.ToInt32(Console.ReadLine());
                k++;
                suma += i;
                if (i==0)
                {
                    k--;
                    break;

                }
            }
            serar =(float) suma / k;
            Console.WriteLine("Кількість введених чисел = {0}", k);
            Console.WriteLine("Сума введених чисел = {0}", suma);
            Console.WriteLine("Середнє арифметичне = {0}", serar);
            Console.ReadKey();
        }
    }
}
