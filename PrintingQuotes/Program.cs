using System;

namespace PrintingQuotes
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
            string quote = ReadInput("What is the quote?");
            string author = ReadInput("Who said it?");
            Console.WriteLine(author + " says, " + "\"" + quote + "\"");
        }
    }
}
