using System;

namespace p._002
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();


            while (line != "")
            {
                int number = Int32.Parse(line);
                if (number >= 51)
                {
                    Console.WriteLine((number - 51) * 3);
                }
                else
                {
                    Console.WriteLine(51 - number);
                }
                line = Console.ReadLine();
            }
            return;
        }
    }
}
