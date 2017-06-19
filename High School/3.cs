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
            Console.Title ="Zadanie 3";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            //
            int a, b, a1, b1;
            string str;
            //
            while (true)
            {
                Console.Write("Podaj a: ");
                str = Console.ReadLine();
            
                try
                {
                    a= int.Parse(str);
                    break;
                }

                catch (FormatException)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Podana liczba jest blednego formatu");
                }

                catch (OverflowException)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Podana libcza wychodzi poza zakres zmiennej");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Sproboj jeszcze raz");
            }
                        while (true)
            {
                Console.Write("Podaj b: ");
                str = Console.ReadLine();
            
                try
                {
                    b= int.Parse(str);
                    break;
                }

                catch (FormatException)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Podana liczba jest blednego formatu");
                }

                catch (OverflowException)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Podana libcza wychodzi poza zakres zmiennej");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Sproboj jeszcze raz");
            }

            a1=a;
            b1=b;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                if (a < b)
                {
                    b = b - a;
                }
            }
            Console.WriteLine("Najwiekszy wspolny dzielnik liczb ({0},{1}) to {2}", a1, b1, a);

        }
    }
}
