using System;

namespace student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string fname = Console.ReadLine();


            Console.WriteLine("Enter Last Name: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Birth Year: ");
            int byear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            String pword = fname +"*"+ byear;
            Console.WriteLine("Hello " + fname+" "+ lname);
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("Your temporary password is: " + pword);
        }
    }
}
