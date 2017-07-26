using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[50];
            int k,kilkist=0;
            Random ran = new Random();
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = ran.Next(1, 20);
                Console.WriteLine(m[i]);
            }
            Console.WriteLine("Vvediy число k");
            k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == k)
                {
                    Console.WriteLine("Chyslo k e v massyvi m");

                    break;
                }
                else if (m[i] != k && i == (m.Length - 1))
                {
                    Console.WriteLine("Chysla k nemae v massyvi m");
                }
            }

            foreach (int q in m)
                {
                    if (q == k)
                    {
                        kilkist++;
                    }

                }
                int[] b = new int[kilkist];


                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = 0; j < m.Length; j++)
                    {
                        if (m[j] == k)
                        {
                            b[i] = j;
                            i++;
                        }

                    }

                }
                foreach (int u in b)
                {
                    Console.WriteLine($"Масив індексів зі значенням k = {u}");


                }

            

            Console.ReadLine();
        }
    }
}
