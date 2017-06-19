using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Zadanie 8";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            uint liczbaElementow;

            while (true)
            {
                Console.Write("Podaj liczbe elementow do posortowania: ");
                string str = Console.ReadLine();

                try
                {
                    liczbaElementow = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana wartosc jest blednego formatu!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Podana wartosc wykracza poza zakres zmiennej!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UWAGA! Napotkano koniec strumienia!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            int[] tablica = new int[liczbaElementow];

            for (uint i = 1; i <= liczbaElementow; i++)
            {
                while (true)
                {

                    Console.Write("Podaj wartosc elementu {0} : ", i);
                    string str = Console.ReadLine();

                    try
                    {
                        tablica[i-1] = int.Parse(str);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("UWAGA! Podana wartosc jest blednego formatu!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("UWAGA! Podana wartosc wykracza poza zakres zmiennej!");
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
                
            for (uint j = 1; j < liczbaElementow; j++)
            {
                    uint d = j;

                    while (tablica[d] < tablica[d - 1])
                    {
                        int t = tablica[d];
                        tablica[d] = tablica[d - 1];
                        tablica[d - 1] = t;

                        d--;
                    }
            }

                Console.WriteLine("Posortowane elementy:");
                for (uint j= 0; j < liczbaElementow; j++)
                {
                    Console.WriteLine("" + tablica[j]);
                }


            }
        }
    }

