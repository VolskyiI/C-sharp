using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    struct Student
    {
        public string prizwyshe;
        public string imja;
        public int kurs;
        public int wik;
        public int matematyka;
        public int fizyka;
        public int himija;
        public int english;
        public Student(string p, string i, int k, int w, int m, int f, int h, int e)
        {
            prizwyshe = p;
            imja = i;
            kurs = k;
            wik = w;
            matematyka = m;
            fizyka = f;
            himija = h;
            english = e;
        }
        public void Info()
        {
            Console.WriteLine($"student: {prizwyshe} {imja} \tKurs: {kurs} Vik: {wik} matematyka:{matematyka} fizyka:{fizyka} himija:{himija} english:{english}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student[] st = new Student[10];
            st[0] = new Student("Ivanow", "Iwan", 5, 25, 3, 4, 4, 2);
            st[1] = new Student("Petrow", "Petro", 4, 22, 5, 5, 5, 5);
            st[2] = new Student("Stepo", "Stepan", 3, 18, 3, 3, 2, 4);
            st[3] = new Student("Zahariw", "Zahar", 4, 21, 5, 5, 5, 5);
            st[4] = new Student("Romanow", "Roman", 2, 26, 4, 3, 4, 4);
            st[5] = new Student("Oleksa", "Sasha", 3, 19, 3, 2, 2, 2);
            st[6] = new Student("Tarasiw", "Taras", 3, 24, 4, 5, 3, 2);
            st[7] = new Student("Pawkiw", "Pawlo", 3, 22, 3, 4, 4, 3);
            st[8] = new Student("Filipow", "Filip", 5, 20, 4, 2, 3, 3);
            st[9] = new Student("Koljada", "Kolia", 3, 21, 4, 5, 4, 3);

            Console.WriteLine("Студенти віком від 20-ти років");
            for (int i = 0; i < 10; i++)
            {
                if (st[i].wik > 20)
                {
                    st[i].Info();

                }

            }
            //Console.Clear();
            Console.WriteLine("Список студентів за віком");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (st[i].wik < st[j].wik)
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
            //Console.Clear();
            Console.WriteLine("Список студентів отримавших оцінку 2");
            for (int i = 0; i < 10; i++)
            {
                if (st[i].matematyka == 2 || st[i].fizyka == 2 || st[i].himija == 2 || st[i].english == 2)
                {
                    st[i].Info();
                }

            }
            //Console.Clear();
            Console.WriteLine("Список студентів відмінників");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (st[i].matematyka == 5 && st[i].fizyka == 5 && st[i].himija == 5 && st[i].english == 5)
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