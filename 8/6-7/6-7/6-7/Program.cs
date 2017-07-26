using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a=new int[10];
            Random ran = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ran.Next(1, 10);
            }
            int sum = 0;
            Matem.Info(a);
            Matem.Max(a);
            Console.ReadLine();
        }
    }
}
