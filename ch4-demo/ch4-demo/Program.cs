﻿using System;

namespace ch4_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More controle statemnet");
            Console.Write("Enter a Dwarf number");
            int nbr = int.Parse(Console.ReadLine());

            switch (nbr)
            {
                case 1:
                    Console.WriteLine("Sleepy");
                
                    break;
                case 2:
            
                    Console.WriteLine("Dopey");
               
                    break;
                case 3:
            
                    Console.WriteLine("Bashful");
                
                    break;
                case 4:
            
                    Console.WriteLine("Grumpy");
            
                    break;
                case 5:
            
                    Console.WriteLine("Sneezy");
               
                    break;

                case 6:
                    Console.WriteLine("Doc");
                
                    break;

                case 7:
                    Console.WriteLine("Happy");
                
                    break;

            }
        }
    }
}
