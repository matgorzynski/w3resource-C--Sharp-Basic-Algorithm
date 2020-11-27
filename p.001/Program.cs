/*
 * 
 * Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
 * 
 * Sample Input:
 * 1, 2
 * 3, 2
 * 2, 2
 * Expected Output:
 * 3
 * 5
 * 12 
 */

using System;

namespace p._001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            
            
            while(line[0] != "")
            {
                Console.WriteLine(Int32.Parse(line[0]) + Int32.Parse(line[1]));
                line = Console.ReadLine()?.Split();
            }
            return;
        }
    }
}