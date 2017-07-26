using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8
{
    class Student
    {
        private string prizwyshe;
        private string imja;
        private int kurs;
        private int wik;
        private int matematyka;
        private int fizyka;
        private int himija;
        private int english;
        public int Stypendia { get; set; }

        public Student(string prizwyshe, string imja, int kurs, int wik, int matematyka, int fizyka, int himija, int english,int Stypendia)
        {
            this.prizwyshe = prizwyshe;
            this.imja = imja;
            this.kurs = kurs;
            this.wik = wik;
            this.matematyka = matematyka;
            this.fizyka = fizyka;
            this.himija = himija;
            this.english = english;
            this.Stypendia = Stypendia;
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
        public int Matematyka
        {
            get
            { return matematyka; }
            set
            {
                if (matematyka>=2&& matematyka <= 5)
                {
                    matematyka = value;
                }
                else
                {
                    Console.WriteLine($"Takogo bala nemae");      
                }
            }
        }

        public int Himija        {
            get
            { return himija; }
            set
            {
                if (himija >= 2 && himija <= 5)
                {
                    himija = value;
                }
                else
                {
                    Console.WriteLine($"Takogo bala nemae");
                }
            }
        }

        public int Fizyka
        {
            get
            { return fizyka; }
            set
            {
                if (fizyka >= 2 && fizyka <= 5)
                {
                    fizyka = value;
                }
                else
                {
                    Console.WriteLine($"Takogo bala nemae");
                }
            }
        }

        public int English
        {
            get
            { return english; }
            set
            {
                if (english >= 2 && english <= 5)
                {
                    english = value;
                }
                else
                {
                    Console.WriteLine($"Takogo bala nemae");
                }
            }
        }
        
        public void Info()
        {
            Console.WriteLine($"student: {prizwyshe} {imja} \tKurs: {kurs} Vik: {wik} matematyka:{matematyka} fizyka:{fizyka} himija:{himija} english:{english} stypendia: {Stypendia}");
        }
    }
}
