using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            st[0] = new Student("Ivanow", "Iwan", 5, 25);
            st[1] = new Student("Petrow", "Petro", 2, 22);
            st[2] = new Student("Stepanenko", "Stepan", 3, 18);
            st[3] = new Student("Zahariw", "Zahar", 4, 21);
            st[4] = new Student("Romanow", "Roman", 2, 26);
            st[5] = new Student("Oleksandriw", "Sasha", 3, 19);
            st[6] = new Student("Tarasiw", "Taras", 2, 24);
            st[7] = new Student("Pawkiw", "Pawlo", 3, 22);
            st[8] = new Student("Filipow", "Filip", 5, 20);
            st[9] = new Student("Koljada", "Kolia", 3, 21);

            Console.WriteLine("Studenty wikom wid 20-ty rokiw");

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].GetWik() > 20)
                {
                    st[i].Info();
                }

            }
            Console.WriteLine($"zmina kursu dla 3-h studentiv");
            st[2].SetKurs(4);
            st[5].SetKurs(5);
            st[8].SetKurs(3);
            Console.WriteLine("Spysok studentiv za wikom");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (st[i].GetWik() < st[j].GetWik())
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
            Console.ReadLine();
        }
    }
}
