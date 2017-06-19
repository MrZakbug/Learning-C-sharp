using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zadanie drugie";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int a, b, c;
            string str;

            while (true)
            {
                Console.Write("Podaj a: ");
                str = Console.ReadLine();

                try
                {
                    a = int.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
            while (true)
            {
                Console.Write("Podaj b: ");
                str = Console.ReadLine();

                try
                {
                    b = int.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
            while (true)
            {
                Console.Write("Podaj c: ");
                str = Console.ReadLine();

                try
                {
                    c = int.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }

            if (c > 0)
            {
                Console.WriteLine("Wartosc wyrazenia wynosi {0}", a * a + b);
            }
            if (c < 0)
            {
                Console.WriteLine("Wartosc wyrazenia wynosi {0}", a - b * b);
            }
            if (c == 0)
                if (a==b)
                {
                    Console.WriteLine("Proba dzielenia przez zero");
                }
                else
                    {
                        Console.WriteLine("Wartosc wyrazenia wynosi {0}", a - b * b);
                    }


        }
    }
}
