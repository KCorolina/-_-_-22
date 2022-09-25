using System;

namespace ex1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            string str = Console.ReadLine();
            int rowCount = int.Parse(str);
            var star = "*";
            if(rowCount > 0)
            {
                while (star.Length <= rowCount)
                {
                    Console.WriteLine(star);
                    star += "*";
                }
            }
            else
            {
                Console.WriteLine("Неверный параметр");
            }
        }
    }
}
