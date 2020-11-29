/*
 * 
 * Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
 * 
 * Sample Input:
 * 53
 * 30
 * 51
 * Expected Output:
 * 6
 * 21
 * 0
 * 
 */

using System;

namespace p._002
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();


            while (line != "")
            {
                int number = Int32.Parse(line);
                if (number >= 51)
                {
                    Console.WriteLine((number - 51) * 3);
                }
                else
                {
                    Console.WriteLine(51 - number);
                }
                line = Console.ReadLine();
            }
            return;
        }
    }
}
