using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=245,x1,x2,x3;
            x1 = x / 100;
            x2 = x/10%10  ;
            x3 = x%10;
            Console.WriteLine(x1*x2*x3);
            Console.ReadKey();

        }
    }
}
