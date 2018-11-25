using System;

namespace HelloWorld
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
            Console.WriteLine("Hello, {0}, nice to meet you!", ReadInput("What is your name?"));
        }
    }
}
