using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Pes :Tvaryna,Iagresive,Iignor
    {
        private string poroda;
        private string pryznachennia;

        public Pes(string poroda, string pryznachennia, string klychka, string type, string size, string color, int age, int qlegs, bool tail) : base(klychka, type, size, color, age, qlegs, tail)
        {
            this.poroda = poroda;
            this.pryznachennia = pryznachennia;
        }

        public override void display()
        {
            Console.WriteLine($"Poroda:{poroda},Desteny{ pryznachennia},Klychka:{ Klychka},Typ: { Type},Rozmir: { Size},Kolir: { Color},Wik: { Age},Kilkist lap: { Qlegs},Hwist: { Tail}");
        }

        public override void Sound()
        {
            Console.WriteLine($"gaw");
        }

        void Iagresive.reaction()
        {
            Console.WriteLine($"Pes {Klychka} atakue");
        }

        void Iignor.reaction()
        {
            Console.WriteLine($"Pes {Klychka} ignoryt");
        }
    }

}
