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
            Console.Title = ("Zadanie 5");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //            
            int a, b;
            b = 0;
            string str;
            //
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liczba jest blednego formatu");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liczba wychodzi poza zakres zmiennej");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sprobuj jeszcze raz");
            }

                                
                    if (a % 2 != 0)
            {
                for (b = 3; b < a; b += 2)
                {
                    if (a % b == 0)
                    {
                        Console.WriteLine("Liczba jest podzielna przez:{0}", b);
                        return;
                    }
                    
                }
                Console.WriteLine("Jest to liczba pierwsza");
                                
            }
            else
                Console.WriteLine("Nie jest to liczba pierwsza");

        }
    }
}
