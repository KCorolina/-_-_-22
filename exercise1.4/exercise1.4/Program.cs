using System;

namespace exercise1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников,составляющих ёлку");
            string str       = Console.ReadLine();
            int rowTriangles = int.Parse(str);
            var star         = "*";
            int rowCount     = 2;

            if(rowTriangles > 0)
            {
                for(var l = 1; l <= rowTriangles; l++)
                {
                    while (star.Length <= rowCount)
                    {
                        for (var i = 1; i <= rowTriangles - star.Length + 2; i++)
                        {
                            Console.Write(" ");
                        }

                        for (var j = 1; j <= star.Length; j++)
                        {
                            Console.Write("*");
                        }

                        for (var k = star.Length - 1; k >= 1; k--)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                        star += "*";
                    }
                    rowCount++;
                    star = "*";
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}
