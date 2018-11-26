using System;

namespace PrintingQuotes
{
    class Quote {
        public string Author { get; set; }
        public string TheQuote { get; set; }
        public void PrintQuote()
        {
            Console.WriteLine(Author + " says, " + "\"" + TheQuote + "\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quote[] quotes = new Quote[]
            {
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "The secret fo getting ahead is getting started."
                    },
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "Do the right thing. It will gratify some people and astonish the rest."
                    },
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "It is better to keep your mouth closed and let people think you are a fool than to open it and remove all doubt."
                    },
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "Whenever you find yourself on the side of the majority, it is time to pause and reflect."
                    },
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "Don’t go around saying the world owes you a living. The world owes you nothing. It was here first."
                    },
                new Quote() {
                    Author = "Mark Twain",
                    TheQuote = "Get your facts first, then you can distort them as you please."
                    }
            };

            Random rnd = new Random();
            int index = rnd.Next(quotes.Length);

            quotes[index].PrintQuote();
        }
    }
}
