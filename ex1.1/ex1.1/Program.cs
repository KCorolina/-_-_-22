using System;


namespace ex1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину и щирину прямоугольникв");
            string str = Console.ReadLine();
            double length = double.Parse(str);
            string str1 = Console.ReadLine();
            double width = double.Parse(str1);
            if (length < 0 || width < 0)
            {
                Console.WriteLine("Неверные параметры");
            }
            else
            {
                double Square = length * width;
                Console.Write(Square);
            }
        }
    }
}
