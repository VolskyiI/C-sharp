using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Student
    {
        public string prizwyshe;
        public string imja;
        public int kurs;
        public int wik;
        public static int kilkist=0;

        public Student(string prizwyshe, string imja, int kurs, int wik)
        {
            this.prizwyshe = prizwyshe;
            this.imja = imja;
            this.kurs = kurs;
            this.wik = wik;
            kilkist++;
        }
        static Student()
        {
            Console.WriteLine($"Zapracuvav statychnyi construktor");
            
        }
        public static void Kilkist()
        {
            Console.WriteLine($"Kilkist studentiv = {kilkist}");
        }
        public void Info()
        {
            Console.WriteLine($"student: {prizwyshe} {imja}. Kurs: {kurs}. Vik {wik}");
        }
        public void stypendia(int m1)
        {
            this.Info();
            Console.WriteLine($"suma za 1 misiac {m1}");
        }
        public void stypendia(int m1,int m2)
        {
            this.Info();
            Console.WriteLine($"suma za 2 misiac {m1+m2}");
        }
        public void stypendia(int m1, int m2,int m3)
        {
            this.Info();
            Console.WriteLine($"suma za 3 misiac {m1 + m2+m3}");
        }

        public void stypendia(int m1, int m2, int m3, int m4)
        {
            this.Info();
            Console.WriteLine($"suma za 4 misiac {m1 + m2 + m3+ m4}");
        }
    }
}
