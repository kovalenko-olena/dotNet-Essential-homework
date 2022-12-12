using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте коллекцию MyList. 
 * Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
 * индексатор для получения значения элемента по указанному индексу и 
 * свойство только для чтения для получения общего количества элементов. 
 * Реализуйте возможность перебора элементов коллекции в цикле foreach. */
namespace _001
{
    public class Element
    {
        // Конструктор.
        // только int для заполнения Random
        public Element(int value)
        {
            Field1 = value;
        }
        public Element() { }
        // Свойства.
        public int Field1 { get; set; }
    }
    public class MyList<T> : IEnumerable, IEnumerator where T : Element, new()
    {
        public T[] elementsArray = null;

        // свойство только для чтения для получения общего количества элементов
        public int Count
        {
            get
            {
                return elementsArray.Count();
            }
        }
        public MyList()
        {
            elementsArray = new T[0];
        }

        // метод добавления элемента
        public void Add(T value)
        {
            T[] newItems = new T[elementsArray.Length + 1];
            Array.Copy(elementsArray, newItems, elementsArray.Length);
            newItems[elementsArray.Length] = value;
            elementsArray = newItems;
        }

        //индексатор для получения значения элемента по указанному индексу
        public T this[int index]
        {
            get
            {
                return elementsArray[index];
            }
            set
            {
                elementsArray[index] = value;
            }
        }

        // Указатель текущей позиции элемента в массиве.
        int position = -1;

        // Реализация интерфейса IEnumerator.
        // Передвинуть внутренний указатель (position) на одну позицию.
        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
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
            get { return elementsArray[position]; }
        }

        // Реализация интерфейса - IEnumerable.
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List пример
            List<int> newList= new List<int>();
            newList.Add(1);
            newList.Add(2);
            Console.WriteLine(newList[0]);
            Console.WriteLine(newList.Count);
            foreach(int val in newList)
            {
                Console.WriteLine(val);
            }*/

            MyList<Element> newList = new MyList<Element>();

            Random random = new Random();
            
            Console.WriteLine("метод добавления элемента");
            newList.Add(new Element(random.Next(0, 9)));
            newList.Add(new Element(random.Next(0, 9)));
            Console.WriteLine("индексатор для получения значения элемента по указанному индексу: ");
            Console.WriteLine($"индекс = 0 \t->\t {newList[0].Field1}");
            Console.WriteLine($"индекс = 1 \t->\t {newList[1].Field1}");
            Console.WriteLine("свойство только для чтения для получения общего количества элементов: ");
            Console.WriteLine(newList.Count);
            Console.WriteLine("перебор элементов коллекции в цикле foreach");
            foreach (Element e in newList)
            {
                Console.WriteLine(e.Field1);
            }
            Console.ReadLine();
        }
    }
}
