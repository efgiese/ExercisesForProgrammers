using System;

namespace MadLib
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
            string noun = ReadInput("Enter a noun");
            string verb = ReadInput("Enter a verb");
            string adjective = ReadInput("Enter an adjective");
            string adverb = ReadInput("Enter an adverb");
            Console.WriteLine($"Do you {verb} your {adjective} {noun} {adverb}? Thats's hilarious!");
        }
    }
}
