using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            if (double.TryParse(x,out double a))
            {
                a = double.Parse(x);
                double p = a - (int)a;
                if (Math.Abs(p)== 0.5)
                {
                    if (Math.Truncate(a) % 2 == 0)
                    {
                        if (a > 0) Console.WriteLine(Math.Ceiling(a));
                        else Console.WriteLine(Math.Floor(a));
                    }
                    else
                        Console.WriteLine(Math.Truncate(a));
                } else
                {
                    Console.WriteLine(Math.Round(a));
                }
            } else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
