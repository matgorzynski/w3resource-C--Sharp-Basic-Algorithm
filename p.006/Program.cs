/*
 * 
 * Write a C# Sharp program to remove the character in a given position if a given string. 
 * The given position will be in the range 0.. string length -1 inclusive
 * 
 * Sample Input:
 * "Python", 1
 * "Python", o
 * "Python", 4
 * Expected Output:
 * Pthon
 * ython
 * Pythn
 * 
 */
using System;

namespace p._006
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(',');
            while (line.Length>1)
            {
                Console.WriteLine(line[0].Remove(Int32.Parse(line[1]), 1));
                line = Console.ReadLine().Split(',');
            }
        }
    }
}
