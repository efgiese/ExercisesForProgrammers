using System;

namespace CountingCharacters
{
    class Program
    {
        static string ReadInput(string prompt)
        {
            string result = "";
            do
            {
                Console.WriteLine(prompt);
                result = Console.ReadLine();
            } while (result == "");

            return result;
        }
        static void Main(string[] args)
        {
            string input = ReadInput("What is the input string?");
            Console.WriteLine("{0} has {1} characters.", input, input.Length);
        }
    }
}
