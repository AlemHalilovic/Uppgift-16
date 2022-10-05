using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter och sekunder lång är din låt? (Svara så här: 2 minuter 30 sekunder)");
            Console.Write("Svara här: "); string svar = Console.ReadLine().ToLower();

            string[] svarsplit = svar.Split(' ');

            int minuter = int.Parse(svarsplit[0]);
            int sekunder = int.Parse(svarsplit[2]);

            if (minuter == 2 && sekunder >= 45 && sekunder <= 60)
            {
                Console.WriteLine("Din låt får spelas.");
            }

            else if (minuter == 3 && sekunder <= 60)
            {
                Console.WriteLine("Vi spelar gärna din låt.");
            }

            else if (minuter == 4 && sekunder <= 20)
            {
                Console.WriteLine("Vi spelar gärna din låt.");
            }

            else if (sekunder > 60)
            {
                Console.WriteLine("Vi spelar gärna din låt.");

            }

            else
            {
                Console.WriteLine("Din låt får spelas på våran radiostation.");
            }
        }
    }
}