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
