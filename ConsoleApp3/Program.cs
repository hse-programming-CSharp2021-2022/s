using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (double.TryParse(a, out double x) && double.TryParse(b, out double y))
            {
                if ((x * x + y * y <= 2) && (x * x + y * y >= 1))
                    Console.WriteLine("True");
                else
                    Console.WriteLine("false");
            }
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
