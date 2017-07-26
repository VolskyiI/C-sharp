using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Student
    {
        private string prizwyshe;
        private string imja;
        private int kurs;
        private int wik;

        public Student(string prizwyshe, string imja, int kurs, int wik)
        {
            this.prizwyshe = prizwyshe;
            this.imja = imja;
            this.kurs = kurs;
            this.wik = wik;
        }

        public string GetPrizwyshe()
        {
            return prizwyshe;
        }
        public void SetPrizwyshe(string prizwyshe)
        {
            this.prizwyshe = prizwyshe;
        }
        public string GetImja()
        {
            return imja;
        }
        public void SetImja(string imja)
        {
            this.imja = imja;
        }
        public int GetKurs()
        {
            return kurs;
        }
        public void SetKurs(int kurs)
        {
            this.kurs = kurs;
            this.Info();
        }
        public int GetWik()
        {
            return wik;
        }
        public void SetWik(int wik)
        {
            this.wik = wik;
        }


        public void Info()
        {
            Console.WriteLine($"student: {prizwyshe} {imja}. Kurs: {kurs}. wik {wik}");
        }

    }
}
