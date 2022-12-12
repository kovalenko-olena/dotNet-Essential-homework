using System;
using System.Linq;
/*Создайте класс MyList. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List. 
    Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
    индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.*/
namespace _001
{
    class MyList<T>
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
            Array.Copy(items, newItems, items.Length);
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
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            //заполнение myList
            Random random = new Random();
            for (int i = 0; i < random.Next(1,5); i++)
            {
                myList.Add(random.Next(10, 20));
            }
            //вывод
            Console.WriteLine("MyList:");
            for (int i = 0; i < myList.GetCountMember; i++)
            {
                Console.WriteLine(i+" -> "+myList[i]);
            }
            //количество элементов
            Console.WriteLine($"количество элементов {myList.GetCountMember}");
            Console.ReadKey();
        }
    }
}
