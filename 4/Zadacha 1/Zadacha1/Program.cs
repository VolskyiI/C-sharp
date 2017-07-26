using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
             Console.WriteLine("Квадрат числа {0} = {1}",i,i*i);
            }
            Console.ReadKey();
        }    
 }
}
