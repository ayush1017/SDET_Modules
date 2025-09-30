using System;

namespace ConsoleApp2
{
    internal class Program
    {
        // Concatenation is the process of joining two or more strings together to form a single string.
        static void  Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            string response = "Hello, my name is " + FirstName + " and my age is " + age + ".";

            Console.WriteLine(response);

            Console.ReadLine(); // Keeps the console open
        }
    }
}
