/*
 * 
 * Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
 * If the given string length is less than 2 return the original string.    
 * 
 * Sample Input:
 * "C Sharp"
 * "JS"
 * "a"
 * Expected Output:
 * C C C C 
 * JSJSJSJS
 * a
 * 
 */

using System;
using System.Linq;

namespace p._008
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while(line!="")
            {
                if (line.Length == 1)
                    Console.WriteLine(line);
                else
                    Console.WriteLine(string.Concat(Enumerable.Repeat(line.Substring(0, 2), 4)));

                line = Console.ReadLine();
            }
        }
    }
}
