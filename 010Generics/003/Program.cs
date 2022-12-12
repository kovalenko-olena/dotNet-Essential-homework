using System;
using System.Linq;
/* Создайте расширяющий метод: public static T[ ] GetArray(this MyList list) Примените расширяющий метод к экземпляру типа MyList, 
 * разработанному в домашнем задании 2 для данного урока. 
 * Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). */
namespace _003
{
    public class MyList<T>
    {
        private T[] items;
        //свойство только для чтения для получения общего количества элементов
        public int GetCountMember
        {
            get
            {
                return items.Count();
            }
        }

        //метод добавления элемента
        public void Add(T item)
        {
            T[] newItems = new T[items.Length + 1];
            System.Array.Copy(items, newItems, items.Length);
            newItems[items.Length] = item;
            items = newItems;
        }
        //индексатор для получения значения элемента по указанному индексу
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public MyList()
        {
            items = new T[0];
        }
    }

    public static class Extension
    {
        //превратить MyList<T> list в массив типа T newItems
        public static T[] GetArray<T>(this MyList<T> list)
        {
            //newItems - массив типа Т
            T[] newItems = new T[list.GetCountMember];
            for (int i = 0; i < list.GetCountMember; i++)
            {
                newItems[i] = list[i];
            }
            //вывод
            Console.WriteLine("MyList GetArray:");
            foreach(T item in newItems)
            {
                Console.WriteLine("-> " + item);
            }
            return newItems;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            //заполнение myList
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 5); i++)
            {
                myList.Add(random.Next(10, 20));
            }
            //количество элементов
            Console.WriteLine($"количество элементов {myList.GetCountMember}");
            //вывод
            myList.GetArray();

            Console.ReadKey();
        }
    }
}

