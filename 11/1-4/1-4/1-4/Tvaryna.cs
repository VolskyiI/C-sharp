using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    abstract class Tvaryna
    {
    private string klychka;
    private string type;
    private string size;
    private string color;
    private int age;
    private int qlegs;
    private bool tail;

        public Tvaryna(string klychka, string type, string size, string color, int age, int qlegs, bool tail)
        {
            this.klychka = klychka;
            this.type = type;
            this.size = size;
            this.color = color;
            this.age = age;
            this.qlegs = qlegs;
            this.tail = tail;
        }

        public string Klychka { get => klychka; set => klychka = value; }
        public string Type { get => type; set => type = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public int Age { get => age; set => age = value; }
        public int Qlegs { get => qlegs; set => qlegs = value; }
        public bool Tail { get => tail; set => tail = value; }

        public abstract void Sound();
        public virtual void display()
        {
            Console.WriteLine($"{klychka }, {type}, {size}, {color}, {age}, {qlegs}, {tail}");
        }
        
    }
}
