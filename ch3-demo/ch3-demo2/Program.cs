using System;

namespace ch3_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math class and random #s");

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int r1 = rand.Next(6);
                Console.WriteLine("r1 = " + r1);

            }

            //random between min and max
            for (int i = 0; i < 10; i++)
            {
                int r1 = rand.Next(10,20);
                Console.WriteLine("r1 = " + r1);
            }
            //rounding
            double d1 = 85.578888;
            Console.WriteLine("D1= " + d1);
            Console.WriteLine("D1= " + Math.Round(d1));
            Console.WriteLine("D1= " + Math.Round(d1,2));
            Console.WriteLine("D1= " + Math.Round(d1,2,MidpointRounding.AwayFromZero));

            //currency formatting
            double d2 = 199.99;
            Console.WriteLine(d2.ToString("C"));



        }
    }
}
