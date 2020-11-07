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