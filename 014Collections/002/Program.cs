using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static _002.Program;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте коллекцию MyDictionary. 
 * Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса Dictionary. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
 * индексатор для получения значения элемента по указанному индексу и 
 * свойство только для чтения для получения общего количества элементов. 
 * Реализуйте возможность перебора элементов коллекции в цикле foreach. */
namespace _002
{
    internal class Program
    {
        public class Element1
        {
            // Конструктор.
            public Element1(int a)
            {
                Field1 = a;
            }
            public Element1() { }
            // Свойство.
            public int Field1 { get; set; }
        }
        public class Element2
        {
            // Конструктор.
            public Element2(int a)
            {
                Field1 = a;
            }
            public Element2() { }
            // Свойство.
            public int Field1 { get; set; }
        }
        public class MyDictionary<K, T> : IEnumerable, IEnumerator where K : Element1, new() where T : Element2, new()
        {
            public KeyValuePair<K, T>[] elementsArray3 = null;
            // свойство только для чтения для получения общего количества элементов
            public int Count
            {
                get
                {
                    return elementsArray3.Count();
                }
            }
            public MyDictionary()
            {
                elementsArray3 = new KeyValuePair<K, T>[0];
            }

            // метод добавления элемента
            public void Add(K value1, T value2)
            {
                KeyValuePair<K, T>[] newItems3 = new KeyValuePair<K, T>[elementsArray3.Length + 1];
                Array.Copy(elementsArray3, newItems3, elementsArray3.Length);
                newItems3[elementsArray3.Length] = new KeyValuePair<K, T>(value1, value2);
                elementsArray3 = newItems3;
            }

            //индексатор для получения значения элемента по указанному индексу
            public KeyValuePair<K, T> this[int index]
            {
                get
                {
                    return elementsArray3[index];
                }
                set
                {
                    elementsArray3[index] = value;
                }
            }
            //индексатор для получения значения элемента по указанному ключу
            public T this[K key]
            {
                get
                {
                    for (int i = 0; i < elementsArray3.Length; i++)
                    {
                        if (elementsArray3[i].Key == key) return elementsArray3[i].Value;
                    }
                    return default(T);
                }
                
            }
            // Указатель текущей позиции элемента в массиве.
            int position = -1;

            // Реализация интерфейса IEnumerator.
            // Передвинуть внутренний указатель (position) на одну позицию.
            public bool MoveNext()
            {
                if (position < elementsArray3.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    Reset();
                    return false;
                }
            }

            // Установить указатель (position) перед началом набора.
            public void Reset()
            {
                position = -1;
            }

            // Получить текущий элемент набора. 
            public object Current
            {
                get { return elementsArray3[position]; }
            }

            // Реализация интерфейса - IEnumerable.
            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }
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
