using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCheckout
{
  class CheckoutItems
  {
    public float Price { get; set; }
    public int Quantity { get; set; }
    public float ItemTotal { get => Price * Quantity; }
  }

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
        static float ReadFloat(string prompt, float low, float high)
        {
            float result = 0f;
            do
            {
                string floatString = ReadString(prompt);
                bool success = float.TryParse(floatString, out result);
                if (!success)
                {
                    result = low -1;
                }
            } while ((result < low) || (result > high));
            return result;
        }
        static void Main(string[] args)
        {
            List<CheckoutItems> items = new List<CheckoutItems>();
            float tax = 5.5f;
            float price = 0f;
            int quantity = 0;
            int index = 1;
            float resultSubtotal = 0f;
            float resultTax = 0f;
            float resultTotal = 0f;
            string result = "";

            do
            {
                price = ReadFloat($"Enter the price of item {index}:", 0, 100);
                quantity = ReadInt($"Enter the quantity fo the item {index}:", 0, 100);
                items.Add(new CheckoutItems() { Price = price, Quantity = quantity });
                index++;
                Console.WriteLine("Add another item? [Y/n]");
                result = Console.ReadLine();
            } while (result.ToUpper() != "N");

            resultSubtotal = items.Sum(item => item.ItemTotal);
            resultTax = resultSubtotal * tax / 100;
            resultTotal = resultSubtotal + resultTax;

            Console.WriteLine($"Subtotal: {resultSubtotal}€ \nTax: {resultTax}€ \nTotal: {resultTotal}€");
        }
    }
}
