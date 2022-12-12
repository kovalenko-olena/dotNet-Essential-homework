using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. Создайте класс Calculator. 
 * В теле класса создайте четыре метода для арифметических действий: 
 * Add – сложение, Sub – вычитание, Mul – умножение, Div – деление. 
 * Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение. 
 * Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию. 
 * При возникновении ошибок должны выбрасываться исключения.*/
namespace _003
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt;
            double value1 = 0;
            double value2 = 0;
            string operation = "";
            double result = 0;

            Console.WriteLine("Введите первое число");
            txt = Console.ReadLine();
            try
            {
                value1 = Convert.ToInt32(txt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Введите второе число");
            txt = Console.ReadLine();
            try
            {
                value2 = Convert.ToInt32(txt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Введите операцию + - * /");
            txt = Console.ReadLine().Trim();
            try
            {
                char[] oper = { '+', '-', '*', '/' };
                if (txt.IndexOfAny(oper) >= 0)
                {
                    operation = txt;
                }
                else
                {
                    throw new Exception("допустимые операции для ввода + - * /");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            switch (operation)
            {
                case "+":
                    {
                        result = Calculator.Add(value1, value2); break;
                    }
                case "-":
                    {
                        result = Calculator.Sub(value1, value2); break;
                    }
                case "*":
                    {
                        result = Calculator.Mul(value1, value2); break;
                    }
                case "/":
                    {
                        result = Calculator.Div(value1, value2); break;
                    }
            }
            Console.WriteLine($"результат: {result}");
            Console.ReadKey();
        }
    }
}
