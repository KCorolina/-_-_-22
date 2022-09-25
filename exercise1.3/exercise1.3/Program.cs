using System;
namespace exercise1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            string str = Console.ReadLine();
            int rowCount = int.Parse(str);

            var star = "*";

            if(rowCount > 0)
            {
                while(star.Length <= rowCount)
                {
                    for(var i = 1; i <= rowCount - star.Length; i++)
                    {
                        Console.Write(" ");
                    }

                    for(var j = 1; j <= star.Length; j++)
                    {
                        Console.Write("*");
                    }

                    for(var k = star.Length - 1; k >= 1; k--)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                    star += "*";
                }
            }
            else
            {
                Console.WriteLine("Введены неверные данные");
            }
        }
    }
}
