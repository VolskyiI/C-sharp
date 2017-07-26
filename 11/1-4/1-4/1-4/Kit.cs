using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Kit :Tvaryna,Itikae,Iignor
    {
        private string poroda;
        private string hairtype;

        public Kit(string poroda, string hairtype, string klychka, string type, string size, string color, int age, int qlegs, bool tail) :base (klychka,type, size, color, age, qlegs, tail)
        {
            this.poroda = poroda;
            this.hairtype = hairtype;
        }

        public override void Sound()
        {
            Console.WriteLine("meow");
        }

        public override void display()
        {
            Console.WriteLine($"Poroda:{poroda},Sherst:{hairtype},Klychka:{Klychka},Typ:{Type},Rozmir: {Size},Colir: {Color},Wik: {Age},Kilkist lap {Qlegs},Hwist: {Tail}");
        }

        void Itikae.reaction()
        {
            Console.WriteLine($"Kit {Klychka} tikae");
        }

        void Iignor.reaction()
        {
            Console.WriteLine($"Kit {Klychka} ignorue");
        }
    }
}
