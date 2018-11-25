using System;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the input string?");
            string input = Console.ReadLine();
            Console.WriteLine("{0} has {1} characters.", input, input.Length);
        }
    }
}
