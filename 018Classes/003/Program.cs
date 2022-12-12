using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyNamespace;
/*Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении.*/
namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass= new MyClass();
            myClass.Name = "MyClass";
            Console.WriteLine(myClass.Name);
            Console.ReadKey();
        }
    }
}
