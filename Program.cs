using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string FirstName;
            string LastName;
            Console.WriteLine("what is your name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("what is your last name?");
            LastName = Console.ReadLine();
            // Console.WriteLine("hello," + FirstName + " " + LastName);

            Console.WriteLine($"hello, {FirstName} {LastName} ");

        }
    }
}
