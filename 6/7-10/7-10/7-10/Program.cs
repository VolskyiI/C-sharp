﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10
{
    enum Ocinky
    { nezadovilno, zadovilno, dobre, vidminno }
    
    struct Student
    {
        public string prizwyshe;
        public string imja;
        public int kurs;
        public int wik;
        public Ocinky matematyka;
        public Ocinky fizyka;
        public Ocinky himija;
        public Ocinky english;
        public Student(string p, string i, int k, int w, Ocinky m, Ocinky f, Ocinky h, Ocinky e)
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
            st[0] = new Student("Ivanow", "Iwan", 5, 25, Ocinky.dobre, Ocinky.vidminno, Ocinky.zadovilno, Ocinky.dobre);
            st[1] = new Student("Petrow", "Petro", 4, 22, Ocinky.dobre, Ocinky.dobre, Ocinky.dobre, Ocinky.vidminno);
            st[2] = new Student("Stepo", "Stepan", 3, 18, Ocinky.vidminno, Ocinky.zadovilno, Ocinky.dobre,Ocinky.dobre);
            st[3] = new Student("Zahariw", "Zahar", 4, 21, Ocinky.dobre, Ocinky.dobre, Ocinky.dobre, Ocinky.dobre);
            st[4] = new Student("Romanow", "Roman", 2, 26, Ocinky.zadovilno, Ocinky.dobre, Ocinky.dobre, Ocinky.zadovilno);
            st[5] = new Student("Oleksa", "Sasha", 3, 19, Ocinky.nezadovilno, Ocinky.zadovilno, Ocinky.nezadovilno, Ocinky.zadovilno);
            st[6] = new Student("Tarasiw", "Taras", 3, 24, Ocinky.nezadovilno, Ocinky.zadovilno, Ocinky.zadovilno, Ocinky.nezadovilno);
            st[7] = new Student("Pawkiw", "Pawlo", 3, 22, Ocinky.nezadovilno, Ocinky.zadovilno, Ocinky.dobre, Ocinky.zadovilno);
            st[8] = new Student("Filipow", "Filip", 5, 20, Ocinky.vidminno, Ocinky.dobre, Ocinky.vidminno, Ocinky.dobre);
            st[9] = new Student("Koljada", "Kolia", 3, 21, Ocinky.nezadovilno, Ocinky.zadovilno, Ocinky.zadovilno, Ocinky.zadovilno) ;
            foreach (Student u in st )
            {
                Console.WriteLine($"Spysok studentiw ");
                u.Info();
            }
            Console.Clear();
            Console.WriteLine($"Spysok studentiw widminnykiv");
            for (int i = 0; i < 10; i++)
            {
                if ((st[i].matematyka==Ocinky.dobre || st[i].matematyka == Ocinky.vidminno) && (st[i].fizyka == Ocinky.dobre|| st[i].fizyka == Ocinky.vidminno) && (st[i].himija == Ocinky.dobre|| st[i].himija == Ocinky.vidminno) && (st[i].english == Ocinky.dobre|| st[i].english == Ocinky.vidminno))
                {
                st[i].Info();
                }

            }

            Console.ReadLine();
        }

    }
}