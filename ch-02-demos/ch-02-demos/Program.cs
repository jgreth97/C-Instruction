using System;

namespace ch_02_demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //delcaing strings
            string str1 = "Elvis";
            string str2 = "Presley";
            // using variables without a type(var)
            var fullName = str1 +" "+ str2;
            //var number; // cannot use this, must assign a value
            var number = "0";
            double d1;
            double d2;

            //while loop prompt for input , sum then
            //prompt input
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter a decimal value: ");
                d1 = Double.Parse(Console.ReadLine());
                Console.Write("Enter another decimal value: ");
                d2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Sum is: " + (d1 + d2));
                Console.Write("Continue");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }
            //do a simple if statemnt
            Console.Write("Stoplight Color: ");
            String lightColor = Console.ReadLine();

            if (lightColor.Equals("r")){
                Console.WriteLine("Stop");
            }
            else if (lightColor.Equals("y")){
                Console.WriteLine("Slow down bro");
            }
            else if (lightColor.Equals("g")){
                Console.WriteLine("GO GO GO");
            }
         else {
                Console.WriteLine("Invalid Color");
            
            }
        }
    }
}
