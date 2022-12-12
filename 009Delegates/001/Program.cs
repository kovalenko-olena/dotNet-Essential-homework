using System;
/*Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
    Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль. 
    Написать программу, которая будет выполнять арифметические действия, указанные пользователем. */
namespace _001
{
    public delegate double Delegate(double num1, double num2);
    internal class Program
    {
        static void Input(ref double number1, ref double number2)
        {
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out number2);
        }

        static void Main(string[] args)
        {
            Delegate Add = (double num1, double num2) =>
            {
                Input(ref num1, ref num2);
                return num1 + num2;
            };
            Delegate Sub = (double num1, double num2) =>
            {
                Input(ref num1, ref num2);
                return num1 - num2;
            };
            Delegate Mul = (double num1, double num2) =>
            {
                Input(ref num1, ref num2);
                return num1 * num2;
            };
            Delegate Div = (double num1, double num2) =>
            {
                Input(ref num1, ref num2);
                if (num2 == 0)
                {
                    Console.WriteLine("Нельзя делить на ноль!");
                    return 0;
                }
                else return num1 / num2;
            };
            string choice;
            do
            {
                Console.WriteLine("Какие действия будем выполнять?\n " +
                "Сложение: нажмите кнопку +\n " +
                "Вычитание: нажмите кнопку -\n " +
                "Умножение: нажмите кнопку *\n " +
                "Деление: нажмите кнопку /");
                choice = Console.ReadLine().ToString();
                double number1 = 0, number2 = 0, result = 0;

                switch (choice)
                {
                    case "+": result = Add(number1, number2); break;
                    case "-": result = Sub(number1, number2); break;
                    case "*": result = Mul(number1, number2); break;
                    case "/": result = Div(number1, number2); break;
                    case "exit": break;
                    default: Console.WriteLine("Повторите ввод."); break;
                }
                if (choice!="exit") Console.WriteLine("Результат расчета: {0}\n", result);

            } while (choice != "exit");
            Console.ReadKey();
        }
    }
}
