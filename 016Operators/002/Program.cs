using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс House c двумя полями и свойствами. 
 * Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое копирование соответственно. 
 * Реализуйте простой способ проверки.*/
namespace _002
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            House original = new House(1, 2, 3, 4);
            House clone = original.Clone() as House;
            House deepClone = original.DeepClone() as House;
            Console.WriteLine(original.ToString());
            Console.WriteLine(clone.ToString());
            Console.WriteLine(deepClone.ToString());

            Console.WriteLine("После установки новых значений в поле и свойство:");
            clone.field1 = 98;
            clone.Someth1 = 99;
            deepClone.field1 = 98;
            deepClone.Someth1 = 99;

            Console.WriteLine(original.ToString());
            Console.WriteLine(clone.ToString());
            Console.WriteLine(deepClone.ToString());

            Console.ReadKey();
        }
    }
}
