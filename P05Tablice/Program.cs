using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb; //deklaracja
            tablicaLiczb = new int[20];//alokowanie miejsca
            tablicaLiczb[0] = 12;//uzupelineie danymi
            tablicaLiczb[19] = 674;

            foreach (var item in tablicaLiczb)
            {
                Console.WriteLine(item);
            }

            int[] b = new int[10] {1,2,3,4,5,6,7,8,9,0};
            int[] c = { 1, 2, 3, 4, 5 };

            Console.WriteLine(c[0]);


            //tablice wielowymiarowe
            int[,] kostka = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            kostka[0, 0] = 100;
            Console.WriteLine("Kostka:");
            foreach (var item in kostka)
            {
                Console.WriteLine(item);
            }

            //jak sprawdzic wysokosc i szerokosc kostki:
            Console.WriteLine(kostka.Length);//liczba elementowe tu 6
            Console.WriteLine(kostka.LongLength);//liczba wymiarów tu 2

            Console.WriteLine($"Pierwszy wymiar: {kostka.GetLength(0)}");
            Console.WriteLine($"Pierwszy wymiar: {kostka.GetLength(1)}");


            

            /* output each array element's value */
            for (int i = 0; i < kostka.GetLength(0); i++)
            {

                for (int j = 0; j < kostka.GetLength(1); j++)
                {
                    Console.Write($"{kostka[i, j]} ");

                }
                Console.WriteLine();
            }
            ////for:

            //for (int i = 0; i < kostka.Length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {

            //    }
            //}



            Console.ReadLine();
           // Console.WriteLine(tablicaLiczb);

        }
    }
}
