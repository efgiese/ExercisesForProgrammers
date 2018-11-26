using System;

namespace PrintingQuotes
{
    struct Quote {
        public string author;
        public string quote;
        public void PrintQuote()
        {
            Console.WriteLine(author + " says, " + "\"" + quote + "\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int index = rnd.Next(3);

            Quote[] quotes = new Quote[3];

            quotes[0].author = "Mark Twain";
            quotes[0].quote = "The secret fo getting ahead is getting started.";
            quotes[1].author = "Mark Twain";
            quotes[1].quote = "Do the right thing. It will gratify some people and astonish the rest.";
            quotes[2].author = "Mark Twain";
            quotes[2].quote = "It is better to keep your mouth closed and let people think you are a fool than to open it and remove all doubt.";

            quotes[index].PrintQuote();
        }
    }
}
