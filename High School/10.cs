using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Zadanie 10 (Obliczanie wartosci wielomianiu schematem Hornera");
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            int stopienWielomianu;
            
            while (true)
            {
                Console.Write("Podaj stopien wielomianu: ");
                string str = Console.ReadLine();

                try
                {
                    stopienWielomianu = int.Parse(str);
                    break;
                }
                catch(FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana liczba jest blednego formatu!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (OverflowException)
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

            int wyrazWolny;

            while (true)
            {
                Console.Write("Podaj wartosc wyrazu wolnego: ");
                string str = Console.ReadLine();

                try
                {
                    wyrazWolny = int.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana liczba jest blednego formatu!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (OverflowException)
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
            
            int[] wspolczynnikiWyrazow = new int[stopienWielomianu];

            for (uint i = 0; i < stopienWielomianu; i++)
            {
                while (true)
                {


                    Console.Write("Podaj wspolczynnik przy x^{0}: ", i+1);
                    string str = Console.ReadLine();

                    try
                    {
                        wspolczynnikiWyrazow[i] = int.Parse(str);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("UWAGA! Podana liczba jest blednego formatu!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    catch (OverflowException)
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
            }

            float x;

            while (true)
            {
                Console.Write("Podaj wartosc x: ");
                string str = Console.ReadLine();

                try
                {
                    x = float.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana liczba jest blednego formatu!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (OverflowException)
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

            float wynik = x * wspolczynnikiWyrazow[stopienWielomianu-1];

            for (int i = stopienWielomianu -2; i >= 0; i--)
            {
                wynik =(wynik * x) + wspolczynnikiWyrazow[i];
            }

            wynik += wyrazWolny;

            Console.WriteLine("Wartosc tego wielomianu wynosi:" + wynik);

        }
    }
}
