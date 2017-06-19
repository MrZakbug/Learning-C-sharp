using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Zadanie 6";
            Console.Clear();

            uint w;

            while (true)
            {
                Console.Write("Jak wysoka ma byc choinka? ");
                string str = Console.ReadLine();

                try
                {
                    w = uint.Parse(str);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczba jest blednego formatu");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
            }

            uint ww = w;
            for (uint i = 1; i <= w; i++)
            {
                for (uint ii = 1; ii < ww; ii++)
                {
                    Console.Write(" ");
                }
                ww--;
                for (uint iii = 0; iii < 2 * i - 1; iii++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            uint www = w;
            for (uint i = 1; i < 2; i++)
            {
                for (uint ii = 1; ii < www; ii++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }
    }
}
