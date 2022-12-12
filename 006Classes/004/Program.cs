using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
Написать программу, которая выводит на экран основные арифметические операции.
 */
namespace _004
{
    static class Calculator
    {
        public static double Add(params double[] values)
        {
            return values.Sum();
        }
        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(params double[] values)
        {
            return values.Aggregate((p, x) => p *= x);
        }
        public static double Divide(double number1, double number2)
        {
            if (number2 != 0)
                return number1 / number2;
            else
            {
                Console.WriteLine("на ноль делить нельзя");
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("Что считаем? Введите выражение без скобок, например 2+8/4*6-4");
            string str = Console.ReadLine().Trim();

            char[] oper = { '+', '-', '*', '/' };
            int pos = str.IndexOfAny(oper);
            if (pos > 0)
            {
                result = double.Parse(str.Substring(0, pos));
                do
                {
                    if (double.TryParse(str.Substring(pos + 1, str.IndexOfAny(oper, pos + 1) == -1 ? str.Length - pos - 1 : str.IndexOfAny(oper, pos + 1) - pos - 1), out double nextValue))
                    { }
                    else
                    {
                        Console.WriteLine("неправильное выражение" + str.Substring(pos + 1, str.Length - pos - 1));
                        Console.ReadKey();
                        return;
                    }
                    switch (str.Substring(pos, 1))
                    {
                        case "+":
                            {
                                result = Calculator.Add(result, nextValue); break;
                            }
                        case "-":
                            {
                                result = Calculator.Substract(result, nextValue); break;
                            }
                        case "*":
                            {
                                result = Calculator.Multiply(result, nextValue); break;
                            }
                        case "/":
                            {
                                result = Calculator.Divide(result, nextValue); break;
                            }
                    }
                    str = str.Substring(pos + 1, str.Length - pos - 1);
                    pos = str.IndexOfAny(oper);
                } while (pos > 0);
            }
            Console.WriteLine("Результат: {0}", result);
            Console.ReadKey();
        }
    }
}
