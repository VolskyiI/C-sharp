using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kit k1 = new Kit("meincoun", "long", "Mico", "cat", "small", "tiger", 5, 4, true);
            Kit k2 = new Kit("shpinks", "absent", "Farao", "cat", "small", "white", 2, 4, true);

            Pes p1 = new Pes("vivcharka","storojowyi" , "muhtar", "dog", "middle", "brown", 3, 4, true);
            Pes p2 = new Pes("taksa", "myslywska", "figo", "dog", "small", "black", 1, 4, true);
            Pes p3 = new Pes("doberman", "fighter", "sharik", "dog", "midlle", "black", 3, 4, false);

            Zvir z1 = new Zvir("sparky", "spider", "small", "red", 2, 8, false);
            Zvir z2 = new Zvir("polly", "bird", "small", "green", 1, 2, true);
            Zvir z3 = new Zvir("gas", "aligator", "big", "green", 8, 4, true);


            k1.display();
            Itikae Kit1 = k1;
            Kit1.reaction();
            k1.Sound();

            k2.display();
            ((Iignor)k2).reaction();
            k2.Sound();

            p1.display();
            ((Iagresive)p1).reaction();
            p1.Sound();

            p2.display();
            ((Iignor)p2).reaction();
            p2.Sound();

            p3.display();
            ((Iagresive)p3).reaction();
            p3.Sound();

            z1.display();
            ((Itikae)z1).reaction();
            z1.Sound();

            z2.display();
            ((Iignor)z2).reaction();
            z2.Sound();

            z3.display();
            ((Iagresive)z3).reaction();
            z3.Sound();


            Console.ReadLine();
        }
    }
}
