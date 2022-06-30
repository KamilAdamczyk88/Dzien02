using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] imiona = new string[5]; ;
            //Console.WriteLine("Podaj 5 imion:");
            //for (int i = 0; i < 5; i++)
            //{
            //    imiona[i] = Console.ReadLine();
            //}
            //Array.Sort(imiona);
            //Array.Reverse(imiona);
            //foreach (var item in imiona)
            //{
            //    Console.WriteLine(item);
            //}

            //tablice tablic
            Console.WriteLine("Tablice tablic:");
            int[][] tabtablic = new int[3][];
            tabtablic[0] = new int[5];
            tabtablic[1] = new int[10];
            tabtablic[2] = new int[2];

            tabtablic[1][0] = 300;
            tabtablic[2][1] = 222;

            foreach (var item in tabtablic)
            {
                foreach (var v in item)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine();
            }

           


            Console.ReadLine();
        }
    }
}
