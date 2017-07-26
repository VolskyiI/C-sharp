using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Zvir : Tvaryna,Iagresive,Itikae,Iignor
    {
        public Zvir(string klychka, string type, string size, string color, int age, int qlegs, bool tail) : base(klychka, type, size, color, age, qlegs, tail)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Harakternyi zvuk dla {Type}");
        }

        void Iagresive.reaction()
        {
            Console.WriteLine($"{Type} atakue");
        }

        void Itikae.reaction()
        {
            Console.WriteLine($"{Type} tikae");
        }

        void Iignor.reaction()
        {
            Console.WriteLine($"{Type} ignoryt");
        }
    }
}
