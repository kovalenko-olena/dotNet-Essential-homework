using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyDict;
/*Используя пример выполненного домашнего задания 3 из 14 урока, 
 * реализуйте возможность подключения вашего пространства имен и работы с MyDictionary аналогично экземпляру класса Dictionary.  */
namespace _001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<Element1, Element2> newDictionary = new MyDictionary<Element1, Element2>();

            Random random = new Random();

            Console.WriteLine("метод добавления элемента");
            newDictionary.Add(new Element1(random.Next(0, 9)), new Element2(random.Next(0, 9)));
            newDictionary.Add(new Element1(random.Next(0, 9)), new Element2(random.Next(0, 9)));
            Element1 elForSearch = new Element1(22);
            newDictionary.Add(elForSearch, new Element2(random.Next(0, 9)));

            Console.WriteLine("индексатор для получения значения элемента по указанному индексу: ");
            Console.WriteLine($"индекс = 0 \t->\t key={newDictionary[0].Key.Field1}\tvalue={newDictionary[0].Value.Field1}");
            Console.WriteLine($"индекс = 1 \t->\t key={newDictionary[1].Key.Field1}\tvalue={newDictionary[0].Value.Field1}");
            Console.WriteLine($"индекс = 1 \t->\t key={newDictionary[2].Key.Field1}\tvalue={newDictionary[0].Value.Field1}");

            Console.WriteLine("свойство только для чтения для получения общего количества элементов: ");
            Console.WriteLine(newDictionary.Count);
            Console.WriteLine("перебор элементов коллекции в цикле foreach");
            foreach (KeyValuePair<Element1, Element2> el in newDictionary)
            {
                Console.WriteLine($"key={el.Key.Field1}\tvalue={el.Value.Field1}");
            }
            Console.WriteLine();
            Console.WriteLine("+индексатор для получения значения элемента по указанному ключу: ");

            Console.WriteLine($"результат   \t->\t key={newDictionary[2].Key.Field1}\tvalue={newDictionary[elForSearch].Field1}");

            Console.ReadLine();
        }
    }
}
