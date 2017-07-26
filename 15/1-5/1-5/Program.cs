using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();

            try
            {
                t1 = t1.ConvertFromIntToTime(-5688);
            }
            catch (InvalidTimeFormatException itfe)
            {
                Console.WriteLine(itfe.Message);
            }
            Console.WriteLine(t1);

            Time chas = new Time();
            Console.WriteLine("Введіть час");

            try
            {
                chas = chas.ConvertFromIntToTime(Int32.Parse(Console.ReadLine()));
                Console.WriteLine(chas);
            }

            catch (OverflowException)
            {

                Console.WriteLine("Значення виходить за межі діапазону");
            }

            catch (InvalidTimeFormatException itfe)
            {
                Console.WriteLine(itfe.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Введено неокнктне значення (тільки цілі числа)");
            }

            finally
            {
                Console.WriteLine("Good By!");
            }

            Console.ReadKey();
        }
    }

}
