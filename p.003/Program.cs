using System;

namespace p._003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ");


            while (line[0] != "")
            {
                if (Int32.Parse(line[0]) == 30 || Int32.Parse(line[1]) == 30 || Int32.Parse(line[0])+ Int32.Parse(line[1])== 30)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

                line = Console.ReadLine().Split(", ");
            }
        }
    }
}
