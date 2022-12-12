using System;
/*Создайте класс с методом помеченным модификатором доступа public. 
 * Докажите, что к данному методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки. */
namespace _002
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Write();
            Console.ReadKey();
        }
    }
}
