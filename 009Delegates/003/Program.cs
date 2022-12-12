using System;
/*Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.*/
namespace _003
{
    public delegate double myDelegate(int number1, int number2, int number3);
    internal class Program
    {
        static void Main(string[] args)
        {
            myDelegate srArifm = delegate (int number1, int number2, int number3) { return (number1 + number2 + number3) / 3.00; };
            int num1 = 4;
            int num2 = 5;
            int num3 = 7;
            double res = srArifm(num1, num2, num3);
            Console.WriteLine($"Первое число {num1} \nВторое число {num2} \nТретье число {num3}");
            Console.WriteLine("среднее арифметическое значение: {0:f2}", res);
            Console.ReadKey();
        }
    }
}
