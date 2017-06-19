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
            Console.Title = "Zadanie 4";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            //
            int a, b = 0;            
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
                    Console.WriteLine("Wprowadzona liczba jest blednego formatu");
                }
                catch (OverflowException)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Wprowadzona liczba wychodzi poza dopuszczalny zakres zmiennej");
                 }
                catch (ArgumentNullException)
                {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Napotkano koniec strumienia");
                 }
            }
            
            while (a > 0)
            {
                b += a % 10;
                a /= 10;
            }
            Console.WriteLine("Suma rozwiniecia dziesietnego tej liczby to: " +b);

        }
    }
}
