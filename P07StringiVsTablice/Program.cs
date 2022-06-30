using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07StringiVsTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane = "Ala ma kota i psa";
            Console.WriteLine(dane[5]);

            var tab = dane.Split(' ');

            string polaczenie = string.Join("/", tab);


            string a= "Kot";
            string b = "Kot";
            Console.WriteLine(a == b);

            char[] c = {'K', 'O', 'T'};
            char[] d = { 'K', 'O', 'T' };
            

            Console.WriteLine(c == d);

            c = d;
            Console.WriteLine(c == d);

            c[1] = 'X';
            Console.WriteLine(d[1]);

            d.CopyTo(c, 0); //kopia

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }


            string[][] original = new string[2][];
            original[0] = new string[3] { "Ala", "Ola", "Kasia" };
            original[1] = new string[4] { "Franek", "Karol", "Marek", "Kamil" };

            string[][] kopia = new string[4][];
            original.CopyTo(kopia, 2);

            kopia[2][1] = "Karolina";

            foreach (var wiersz in original)
            {
                foreach (var item in wiersz)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Nowe:");

            string e = "Dominika";
            string f = e;
            f = f.Replace("D", "e");
            Console.WriteLine(e);
            Console.WriteLine(f.Replace("D", "e"));
            //Console.WriteLine(t);
            


            Console.ReadLine();
        }
    }
}
