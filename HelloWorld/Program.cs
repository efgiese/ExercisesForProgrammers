﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            string output = "Hello, " + input + ", nice to meet you!";
            Console.WriteLine(output);
        }
    }
}
