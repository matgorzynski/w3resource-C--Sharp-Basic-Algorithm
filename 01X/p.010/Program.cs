/*
 * 
 * Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
 * 
 * Sample Input:
 * 3
 * 14
 * 12
 * 37
 * Expected Output:
 * True
 * True
 * True
 * False
 * 
 */
using System;

namespace p._010
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();
                if (number=="")
                {
                    return;
                }

                if (Int32.Parse(number) % 3 == 0 || Int32.Parse(number) % 7 == 0)
                {
                    Console.WriteLine(true);
                    continue;
                }
                Console.WriteLine("False");
            }
        }
    }
}
