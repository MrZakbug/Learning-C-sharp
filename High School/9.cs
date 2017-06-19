using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = ("Zadanie 9 (Sito Eratostenesa)");
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            uint[] liczbyPierwsze = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            uint liczbaBadana;

            while (true)
            {
                Console.Write("Podaj liczbe: ");
                string str = Console.ReadLine();

                try
                {
                    liczbaBadana = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana liczba jest blednego formatu!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                catch(OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana liczba jest poza dopuszczalnym zakresem!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Napotkano koniec strumienia!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            int[] tablica = new int[liczbaBadana];
            for (uint i = 0; i < liczbaBadana; i++)
            {
                tablica[i]=1;
            }
            
            foreach (uint liczbaPierwsza in liczbyPierwsze)
            {
                for (uint j = 2 * liczbaPierwsza; j <= liczbaBadana; j += liczbaPierwsza)
                {
                    tablica[j-1] = 0;
                }

            }
        
            if (liczbaBadana == 1 || tablica[liczbaBadana-1] == 1)
            {
                Console.WriteLine("Podana liczba jest liczba pierwsza");
            }
            else if (tablica[liczbaBadana-1]==0)
            {
                Console.WriteLine("Podana liczba nie jest liczba pierwsza");
            }                      
        }
    }
}
