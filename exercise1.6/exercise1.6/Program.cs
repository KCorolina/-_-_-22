using System;

namespace exercise1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника");

            string str1    = Console.ReadLine();
            double side1   = double.Parse(str1);
            string str2    = Console.ReadLine();
            double side2   = double.Parse(str2);
            string str3    = Console.ReadLine();
            double side3   = double.Parse(str3);

            if(side1 < (side2 + side3) && side2 < (side1 + side3)
                && side3 < (side2 + side1))
            {
                double halfperim = (side1 + side2 + side3) / 2;
                double Square = Math.Sqrt(halfperim * (halfperim - side1) * 
                    (halfperim - side2) * (halfperim - side3));

                Console.WriteLine("Площадь треуголника");
                Console.WriteLine(Square);
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}
