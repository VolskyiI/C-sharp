﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a = new float[30];
            float max=float.MinValue;
            int k = 0;
            Random ran = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] =(float) (ran.Next(1,15))/10;
                Console.WriteLine(a[i]);
                if (a[i] > max)
                {
                    max = a[i];
                    
                    }
            }
            foreach (float q in a)
            {
                if (q == max) 
                {
                    k++;
                }

            }
            int[] b = new int[k];


             for (int i = 0; i <b.Length; i++)
            {
            for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == max)
                        {
                            b[i] = j;
                            i++;
                        }
                                
                      }

            }
            foreach (int u in b)
            {
                Console.WriteLine($"Масив індексів максимальних значень = {u}");
            }
            Console.ReadLine();
        }
    }
}
