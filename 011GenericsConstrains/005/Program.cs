using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте обобщенный класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(), 
 * который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). 
 * Каким должен быть тип, подставляемый под T?*/
namespace _005
{
    // тип, подставляемый под T, должен иметь открытый конструктор без параметров
    public class Dog
    {
        public Dog() { }
    }
    public static class MyClass<T> where T:new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var i=MyClass<Dog>.FactoryMethod();
            Console.WriteLine(i.ToString());
            Console.ReadLine();
        }
    }
}
