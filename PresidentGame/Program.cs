using System;
using System.Collections.Generic;

namespace PresidentGame
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hur många länder vill du skapa?");
            string input = Console.ReadLine();

            int.TryParse(input, out int inputInt);

            List<string> countries = new List<string>();
            
            for (int i = 0; i < inputInt; i++)
            {
                Country country = new Country();
                System.Console.WriteLine("Vad ska land " + (i+1) + " heta?");
                string countryNameInput = Console.ReadLine();

                countryNameInput = country.name; 
            } 

            Console.ReadLine();
        }
    }
}
