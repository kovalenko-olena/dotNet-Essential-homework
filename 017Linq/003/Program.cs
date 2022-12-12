using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic.*/
namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine(calculator.Add("1", 2));
            Console.WriteLine(calculator.Sub(2, 3));
            Console.WriteLine(calculator.Sub("1", 2));
            Console.WriteLine(calculator.Mul(2, 3));
            Console.WriteLine(calculator.Mul("1", 2));
            Console.WriteLine(calculator.Div(3, 3));
            Console.WriteLine(calculator.Div("1", 2));

            // Delay.
            Console.ReadKey();
        }
    }
}
