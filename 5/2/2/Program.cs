﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a = new float[20];
            float suma = 0;
            Random ran = new Random();
            for (int i = 0; i < a.Length; i++)
            { 
                a[i] =((float)ran.Next(1,20)/10);
                Console.WriteLine(a[i]);
                if (i % 2 == 0)
                {
                 suma += a[i];
                }
            }
            Console.WriteLine($"Сумма парнмх позицій дійсних чисел масива = {suma}");
            Console.ReadLine();
        }
    }
}
