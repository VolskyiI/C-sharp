﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            long suma=0;
            Random ran = new Random();

            for (int i = 0; i <a.Length; i++)
            {
                a[i] = ran.Next(1, 20);
                Console.Write("{0}\t",a[i]);
                suma +=a[i] ;
            }
            
            Console.WriteLine($"Сумма чисел масива = {suma}");
            Console.ReadLine();
        }
    }
}
