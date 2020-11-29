/*
 * 
 * Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
 * If the string already begins with 'if', return the string unchanged.
 *
 * Sample Input:
 * "if else"
 * "else"
 * Expected Output:
 * if else
 * if else
 *   
 */


using System;

namespace p._005
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "")
            {
                if (line.Length > 2 && line.Substring(0, 2).Equals("if"))
                {
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine("if " + line);
                }
                line = Console.ReadLine();
            }
        }
    }

}
