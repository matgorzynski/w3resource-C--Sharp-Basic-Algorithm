/*
 * 
 * Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
 * 
 * Sample Input:
 * "Red"
 * "Green"
 * "1"
 * Expected Output:
 * dRedd
 * nGreenn
 * 111
 * 
 */
using System;

namespace p._009
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
                else
                    Console.WriteLine(line[line.Length - 1] + line + line[line.Length - 1]);
                
            }
        }
    }
}
