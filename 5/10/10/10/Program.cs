﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int dobutok = 1;
            int[,] a = new int[3, 5];
            int[] b = new int[5];
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = ran.Next(1, 10);

                    Console.Write("{0}\t", a[i, j]);

                }

                Console.WriteLine();

            }
            for (int l = 0; l < 5; l++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                       
                            dobutok *= a[i, j];
                            //Console.WriteLine($"dobutok= { dobutok}");
                        
                    }

                    b[l] = dobutok;
                    l++;
                    dobutok = 1;

                }
            }
            foreach (int u in b)
            {
                Console.WriteLine($"Масив добутків стовпців = {u}");
            }
            Console.ReadLine();
        }
    }
}
