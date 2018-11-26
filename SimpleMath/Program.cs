using System;

namespace SimpleMath
{
    class Program
    {
        static string ReadString(string prompt)
        {
            string result = "";
            do
            {
                Console.WriteLine(prompt);
                result = Console.ReadLine();
            } while (result == "");

            return result;
        }
        static int ReadInt(string prompt, int low, int high)
        {
            int result = 0;
            do
            {
                string intString = ReadString(prompt);
                bool success = Int32.TryParse(intString, out result);
                if (!success)
                {
                    result = low -1;
                }
            } while ((result < low) || (result > high));

            return result;
        }
        static void Main(string[] args)
        {
            int first = ReadInt("What is the first number?", 0, 100);
            int second = ReadInt("What is the second number?", 0, 100);
            Console.WriteLine($"{first} + {second} = {first + second}");
            Console.WriteLine($"{first} - {second} = {first - second}");
            Console.WriteLine($"{first} * {second} = {first * second}");
            Console.WriteLine($"{first} / {second} = {first / second}");
        }
    }
}
