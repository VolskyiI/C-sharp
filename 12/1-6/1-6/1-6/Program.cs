using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //string k1,str = "Do you like tea or coffee?";
            ////Задача № 2
            //int k;
            //Console.WriteLine("Vvedit cile chyslo");
            //k1 = Console.ReadLine();
            //k = int.Parse(k1);
            //Console.WriteLine(str.Insert(k, Console.ReadLine()));
            ////Задача №3
            ////
            //str = "Do coffee you you like tea coffee or like coffee?";
            //int count = 0;
            //string temp=null;
            //char[] point=new char[] { ' ', ',', '.', ':', '\t', '?', '!' };
            //string[] slowa = str.Split (point);
            //for (int i = 0; i < slowa.Length; i++)
            //{
            //    for (int j = 0; j < slowa.Length; j++)
            //    {
            //        temp = slowa[i];
            //        if (temp.Equals(slowa[j]))
            //        {

            //            count++;
            //        }

            //    }

            //    Console.WriteLine($"slowo {temp} povtoruetsa {count} rasziw");
            //    count = 0;
            //}
            //Задача №4
            string str = "Do coffee you you like tea coffee or like coffee?";
            str=str.ToLower();
            Char[] temp;
            Char[] point = new Char[] { ' ', ',', '.', ':', '\t', '?', '!' };
            string[] slowa = str.Split (point);
            for (int i = 0; i < slowa.Length-1; i++)
            {
                temp = slowa[i].ToCharArray();
                temp[0]=Char.ToUpper(temp[0]);
                slowa[i] = Convert.ToString(temp);
                //if (temp[0]!=null)
                //{
                //    temp[0] = Char.ToUpper(temp[0]);
                //}
              
                
            }
            foreach (string a in slowa)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }
}
