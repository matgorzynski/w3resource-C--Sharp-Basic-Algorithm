/*
 * 
 * Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
 * 
 * Sample Input:
 * 30, 0
 * 25, 5
 * 20, 30
 * 20, 25
 * Expected Output:
 * True
 * True
 * True
 * False
 * 
 */

using System;

namespace p._003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ");


            while (line[0] != "")
            {
                if (Int32.Parse(line[0]) == 30 || Int32.Parse(line[1]) == 30 || Int32.Parse(line[0])+ Int32.Parse(line[1])== 30)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

                line = Console.ReadLine().Split(", ");
            }
        }
    }
}
