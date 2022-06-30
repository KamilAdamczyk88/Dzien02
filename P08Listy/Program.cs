using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("cycki");

            //listy
            //Listy moga zmianiac swoja dlugosc
            List<string> imiona = new List<string>();
            imiona.Add("Karolina");
            imiona.Add("Zenon");
            imiona.Add("Ola");
            imiona.Add("Karolina");

            imiona.Remove("Karolina");
            imiona.Remove("Gucio");

            Console.WriteLine(imiona[2]);

            for (int i = 0; i < imiona.Count; i++)
            {
                Console.WriteLine($"{i} {imiona[i]}");
            }

            foreach (var imie in imiona)
            {
                Console.WriteLine(imie);
            }

            List<int> liczby = new List<int>();
            int licznik = 0;
            Console.WriteLine("Podaj ile chcesz liczb:");
            while (true)
            {
                liczby.Add(Convert.ToInt32(Console.ReadLine()));
                
                
                if (liczby.Contains(0))
                {
                    foreach (var jeden in liczby)
                    {

                        if (jeden % 2 == 0)
                        {
                            licznik++;
                            
                            
                        }
                    }
                    Console.WriteLine($"Podzielnych przez 2 jest tyle liczb: {licznik}");
                    break;
                }

            }








            Console.ReadLine();


        }
    }
}
