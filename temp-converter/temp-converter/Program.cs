using System;

namespace temp_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temp coverter");
            
            string choice = "y";
            while (choice.Equals("y"))
            {

                Console.WriteLine("Enter dgrees in Farenheit");
                int Far = int.Parse(Console.ReadLine());
                double cel = (Far - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celcius: " + Math.Round(cel, 1));
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
        }
    }
}
