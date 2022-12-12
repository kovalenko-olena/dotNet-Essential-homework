using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте расширяющий метод: public static T[ ] GetArray(this IEnumerable list){…} 
 * Примените расширяющий метод к экземпляру типа MyList, разработанному в домашнем задании 2 для данного урока. 
 * Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). */
namespace _003
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
    public static class Extension
    {
        //превратить MyList<T> list в массив типа T newItems
        //public static T[] GetArray(this IEnumerable list) {…}
        public static T[] GetArray<T>(this IEnumerable list)
        {
            // количество элементов 
            int count = 0;
            foreach (T item in list)
            {
                count++;
            }
            // массив newItems
            T[] newItems = new T[count];
            int i=0;
            foreach (T item in list)
            {
                newItems[i] = item;
                i++;
            }
            // возвращает массив newItems
            return newItems;
        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Element> newList = new MyList<Element>();

            Random random = new Random();
            
            Console.WriteLine("метод добавления элемента");
            newList.Add(new Element(random.Next(0, 9)));
            newList.Add(new Element(random.Next(0, 9)));
            Console.WriteLine("индексатор для получения значения элемента по указанному индексу: ");
            Console.WriteLine($"индекс = 0 -> {newList[0].Field1}");
            Console.WriteLine($"индекс = 1 -> {newList[1].Field1}");
            Console.WriteLine("свойство только для чтения для получения общего количества элементов: ");
            Console.WriteLine(newList.Count);
            Console.WriteLine();
            Console.WriteLine("значения элементов массива, который вернул расширяющий метод GetArray():");
           
            IEnumerable objects = newList;
            foreach (Element e in Extension.GetArray<Element>(objects))
            {
                Console.WriteLine(e.Field1);
            }
            Console.ReadLine();
        }
    }
}
