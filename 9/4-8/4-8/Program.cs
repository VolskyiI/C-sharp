using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            st[0] = new Student("Ivanow", "Iwan", 5, 25, 3, 4, 4, 2,1000);
            st[1] = new Student("Petrow", "Petro", 4, 22, 5, 5, 5, 5,1500);
            st[2] = new Student("Stepo", "Stepan", 3, 18, 3, 3, 2, 4,1100);
            st[3] = new Student("Zahariw", "Zahar", 4, 21, 5, 5, 5, 5,1500);
            st[4] = new Student("Romanow", "Roman", 2, 26, 4, 3, 4, 4,1200);
            st[5] = new Student("Oleksa", "Sasha", 3, 19, 3, 2, 2, 2,1000);
            st[6] = new Student("Tarasiw", "Taras", 3, 24, 4, 5, 3, 2,1000);
            st[7] = new Student("Pawkiw", "Pawlo", 3, 22, 3, 4, 4, 3,1300);
            st[8] = new Student("Filipow", "Filip", 5, 20, 4, 2, 3, 3,1100);
            st[9] = new Student("Koljada", "Kolia", 3, 21, 4, 5, 4, 3,1000);

            Console.WriteLine("Spysok studentiw otrymawshyh ocinku 2");
            for (int i = 0; i < 10; i++)
            {
                if (st[i].Matematyka == 2 || st[i].Fizyka == 2 || st[i].Himija == 2 || st[i].English == 2)
                {
                    st[i].Info();
                }

            }
            Console.WriteLine("Spysok uspishnosti studentiw ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (st[i].Matematyka == 5 && st[i].Fizyka == 5 && st[i].Himija == 5 && st[i].English == 5)
                    {
                        Student t = st[i];
                        st[i] = st[j];
                        st[j] = t;
                    }

                }

            }
            foreach (Student q in st)
            {
                q.Info();
            }
            Console.WriteLine("Spysok studentiv z najbilshoju stypendieu");
            int max = int.MinValue;
            for (int i = 0; i < st.Length; i++)
            {
                if (max<st[i].Stypendia)
                {
                    max = st[i].Stypendia;
                }
            }
            foreach (var q in st)
            {
                if (q.Stypendia==max)
                {
                    q.Info();
                }
            }
            Console.ReadLine();
        }
    }
}
