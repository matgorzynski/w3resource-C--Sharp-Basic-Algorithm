/*
 * 
 * Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
 * 
 * Sample Input:
 * 103
 * 90
 * 89
 * Expected Output:
 * True
 * True
 * False
 * 
 */
using System;

namespace p._004
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "")
            {
                int number = Int32.Parse(line);
                if (Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                line = Console.ReadLine();
            }
        }
    }
}
