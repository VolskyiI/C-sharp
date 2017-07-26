using System;
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
            int [] A = new int[10];
            Random ran = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = ran.Next(1, 7);
            }
            Matem obj1 = new Matem();
            obj1.Info(A);
            obj1.Max(A);
            obj1.Operation(A);


            Console.ReadLine();
                
        }
    }
}
