using System;

namespace PrintingQuotes
{
    struct Quote {
        public string author;
        public string quote;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int index = rnd.Next(3);

            Quote[] qoutes = new Quote[3];

            qoutes[0].author = "Mark Twain";
            qoutes[0].quote = "The secret fo getting ahead is getting started.";
            qoutes[1].author = "Mark Twain";
            qoutes[1].quote = "Do the right thing. It will gratify some people and astonish the rest.";
            qoutes[2].author = "Mark Twain";
            qoutes[2].quote = "It is better to keep your mouth closed and let people think you are a fool than to open it and remove all doubt.";

            Console.WriteLine(qoutes[index].author + " says, " + "\"" + qoutes[index].quote + "\"");
        }
    }
}
