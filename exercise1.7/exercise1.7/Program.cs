using System;

namespace exercise1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            string str1  = Console.ReadLine();
            byte number1 = byte.Parse(str1);
            string str2  = Console.ReadLine();
            byte number2 = byte.Parse(str2);

            byte multiplicat = (byte)(number1 & number2);
            Console.WriteLine($"побитовое И: {multiplicat}");

            byte summa       = (byte)(number2 | number1);
            Console.WriteLine($"побитовое ИЛИ:{summa}");

            byte exclsumma   = (byte)(number2 ^ number1);
            Console.WriteLine($"побитовое исключающее ИЛИ:{exclsumma}");
        }
    }
}
