using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Matem
    {
        //vyvid masyva
        public void Info(int[] A)
        {
            foreach (int s in A)
            {
                Console.WriteLine($"{s}");
            }
        }
        public void Max(int[] A)
        { int max = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
            {
                    max = A[i];
             }

            }
            Console.WriteLine($"Максимальне значення= {max}");
    
        }
        public void Operation(int[] A)
        {
            while (true)
            {

                Console.WriteLine($"Vvedit symvol + dlja wywedennia sumy ,abo * dla vyvedennia dobutku elementiv masyvu");
                string b = Console.ReadLine();
                int suma = 0;
                int dobutok = 1;
                if (b == "+")
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        suma += A[i];
                    }
                    Console.WriteLine($"Suma = {suma}");
                    break;
                }
                else if (b == "*")
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        dobutok *= A[i];
                    }
                    Console.WriteLine($"Dobutok = {dobutok}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Wwedeno nevirnyi synvol");
                }
            }
        }
    }
}
