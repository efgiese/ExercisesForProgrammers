using System;

namespace RetirementCalculator
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
            var currentYear = DateTime.Now.Year;
            int age = ReadInt("What is your current age?", 1, 100);
            int retire = ReadInt("At what age would you like to retire?", 1, 100);
            int leftYears = retire - age;
            if (leftYears < 0)
            {
                Console.WriteLine("You can already retire!");
            }
            else
            {
                Console.WriteLine($"You have {leftYears} years left until you can retire.");
                Console.WriteLine($"It's {currentYear}, so you can retire in {currentYear + leftYears}.");
            }
        }
    }
}
