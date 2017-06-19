using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Zadanie 7";

            string str;
            uint s, w, k;
            int nadPrzekatna= 0, podPrzekatna =0;

            while (true)
            {

                Console.Write("Podaj stopien macierzy kwadratowej: ");
                str = Console.ReadLine();
                try
                {
                    s = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podana liczba jest blednego formatu!");

                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podana liczba jest poza dopuszczalnym zakresem!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Napotkano koniec strumienia!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            
            int[,] macierz = new int[s, s];

            for (w = 0; w < s; w++)
            {
                for (k = 0; k < s; k++)
                {
                    while (true)
                    {

                        Console.Write("Podaj wartosc elementu ({0},{1}) macierzy: ", w + 1, k + 1);
                        str = Console.ReadLine();

                        try
                        {
                            macierz[w, k] = int.Parse(str);
                            break;
                        }
                        catch (FormatException)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Podana liczba jest blednego formatu!");

                        }
                        catch (OverflowException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Podana liczba jest poza dopuszczalnym zakresem!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        catch (ArgumentNullException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Napotkano koniec strumienia!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                }
            }

            for (w=0; w < s; w++)
            {
                for (k = 0; k < s; k++)
                {
                    if (w > k)
                    {
                        podPrzekatna += macierz[w, k];
                    }
                    else if (w < k)
                    {
                        nadPrzekatna += macierz[w, k];
                    }
                }
            }

            Console.Write("Suma elementow powyzej glownej przekatnej macierzy ({0}) ", nadPrzekatna);
            if (nadPrzekatna < podPrzekatna)
                Console.Write("nie ");
            Console.Write("jest wieksza od sumy elementow ponizej glownej przekatnej macierzy ({0})", podPrzekatna);

        }
    }
}
