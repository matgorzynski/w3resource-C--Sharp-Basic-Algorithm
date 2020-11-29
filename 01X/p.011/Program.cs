/*
 *  
 * Write a C# Sharp program to create a new string taking the first 3 characters of a given string 
 * and return the string with the 3 characters added at both the front and back. 
 * If the given string length is less than 3, use whatever characters are there.
 * 
 * Sample Input:
 * "Python"
 * "JS"
 * "Code"
 * Expected Output:
 * PytPythonPyt
 * JSJSJS
 * CodCodeCod
 * 
 * 
 */
using System;
using System.Linq;

namespace p._011
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "")
                    return;

                if(line.Length<=3)
                {
                    Console.WriteLine(string.Concat(Enumerable.Repeat(line, 3)));
                }
                else
                {
                    Console.WriteLine(line.Substring(0, 3) + line + line.Substring(0, 3));
                }
            }
                    
        }
    }
}
