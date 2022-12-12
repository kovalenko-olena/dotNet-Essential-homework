using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
  Требуется: Создайте класс Printer. В теле класса создайте метод void Print(string value), 
  который выводит на экран значение аргумента. Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, 
  и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
  Обязательно используйте приведение типов.
*/
namespace _006_HW
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ForegroundColor = color;
        }
    }
    class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
            Console.ForegroundColor = color;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer;
            printer = new Printer();
            printer.Print("hello! I'm Printer");
            printer = new RedPrinter();
            printer.Print("hello! I'm RedPrinter");
            printer = new GreenPrinter();
            printer.Print("hello! I'm GreenPrinter");
            printer = new Printer();
            printer.Print("hello! I'm Printer");
            Console.ReadKey();
        }
    }
}
