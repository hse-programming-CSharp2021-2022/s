using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();//Вводим 1 число
            double y;
            if (double.TryParse(b,out y))
            {
                y = double.Parse(b);//Преобразуем в double
                if (y>0)
                {
                    double x = (y-(int)y)*10;
                    Console.WriteLine((int)x);//Выводим первую цифру после запятой
                } else
                {
                    Console.WriteLine("Incorrect input");//Если Введённое значение неположительно
                }
            } else
            {
                Console.WriteLine("Incorrect input");//Если введённое значение невозможно преобразовать в число
            }
        }
    }
}
