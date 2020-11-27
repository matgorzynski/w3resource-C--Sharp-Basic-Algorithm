/*
 * 
 * Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
 * 
 * Sample Input:
 * "abcd"
 * "a"
 * "xy"
 * Expected Output:
 * 
 * dbca
 * a
 * yx
 * a
 * 
 */

using System;

namespace p._007
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while(line!="")
            {
                if(line.Length==1)
                {
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine(line.Substring(line.Length - 1) + line.Substring(1, line.Length - 2) + line.Substring(0, 1));
                }

                line = Console.ReadLine();

            }
        }
    }
}
