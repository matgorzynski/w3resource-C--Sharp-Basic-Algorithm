/*
 * 
 * Write a C# Sharp program to check if a given string starts with 'C#' or not.
 * 
 * Sample Input:
 * "C# Sharp"
 * "C#"
 * "C++"
 * Expected Output:
 * True
 * True
 * False
 * 
 */
using System;

namespace p._012
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "")
                    return;

                Console.WriteLine(line.Substring(0, 2).Contains("C#"));
            }
        }
    }
}
