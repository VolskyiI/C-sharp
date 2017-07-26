using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "3+i*4";
            ComplexNumber obj1 = new ComplexNumber(1,2);
            Console.WriteLine(obj1.ToString());
            obj1 =(ComplexNumber)str;
            Console.WriteLine(obj1);

            ComplexNumber obj2 = new ComplexNumber(3, 2);
            ComplexNumber obj3 = new ComplexNumber(5, 3);
            Console.WriteLine(obj3 < obj2);
            Console.WriteLine(obj3 > obj2);
            Console.WriteLine(obj2 == obj3);
            Console.WriteLine(obj2 != obj3);

            ComplexSet<ComplexNumber> set = new ComplexSet<ComplexNumber>();
            ComplexNumber obj4 = new ComplexNumber(3, 5);
            ComplexNumber obj5 = new ComplexNumber(1, 4);
            ComplexNumber obj6 = new ComplexNumber(2, 6);
            ComplexNumber obj8 = new ComplexNumber(7, 3);
            ComplexNumber obj9 = new ComplexNumber(4, 3);

            set[0] = obj4;
            set[1] = obj5;
            set[2] = obj6;
            set[3] = obj8;
            set[4] = obj9;

            foreach (var cp in set)
            {
                Console.WriteLine(cp);
            }

            string str2 = set[3];
            set[4] = (ComplexNumber)"4+i*3";


            Console.ReadLine();
        }
    }
}
