/*
 * 
 * Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
 * 
 * Sample Input:
 * 120, -1
 * -1, 120
 * 2, 120
 * Expected Output:
 * True
 * True
 * False
 * 
 */

using System;
using System.Linq;

namespace p._013
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] line = Console.ReadLine().Split(", ");
                if (line.Length == 1)
                    return;

                Console.WriteLine(line.Where(x => Int32.Parse(x) < 0).Count()==1 
                    && (line.Where(x=> Int32.Parse(x) < 0).Count() + line.Where(x => Int32.Parse(x) >100).Count()) == line.Length);
            }
        }
    }
}
