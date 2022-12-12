using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс Dictionary. Реализуйте в простейшем приближении возможность использования его экземпляра 
 * аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
 * индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов. */
namespace _002
{
    //Минимально требуемый интерфейс взаимодействия с экземпляром
    interface IDictionary<Key, Value>
    {
        // метод добавления пар элементов
        void AddDictionary(Key key, Value value);
        // индексатор для получения значения элемента по указанному индексу
        KeyValuePair<Key, Value> this[int index] { get; }
        // свойство только для чтения для получения общего количества пар элементов
        int CountDictionary { get; }
    }
    class Dictionary<Key, Value> : IDictionary<Key, Value>
    {
        public KeyValuePair<Key, Value>[] dictionary = new KeyValuePair<Key, Value>[0];

        public KeyValuePair<Key, Value> this[int index] => dictionary[index];

        public int CountDictionary
        {
            get
            {
                return dictionary == null ? 0 : dictionary.Length;
            }
        }

        public void AddDictionary(Key key, Value value)
        {
            KeyValuePair<Key, Value>[] newDictionary = new KeyValuePair<Key, Value>[dictionary.Length + 1];
            for (int i = 0; i < dictionary.Length; i++)
            {
                newDictionary[i] = dictionary[i];
            }
            newDictionary[dictionary.Length] = new KeyValuePair<Key, Value>(key, value);
            dictionary = newDictionary;
        }

        public Dictionary(Key key, Value value)
        {
            AddDictionary(key, value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>(1, "first");
            dictionary.AddDictionary(2, "second");
            dictionary.AddDictionary(3, "third");
            Console.WriteLine("Общее количество пар элементов - " + dictionary.CountDictionary);
            Console.WriteLine("Значения элементов по указанному индексу:");
            for (int i = 0; i < dictionary.CountDictionary; i++)
            {
                Console.WriteLine(dictionary[i].Key + "\t" + dictionary[i].Value);
            }
            Console.ReadKey();
        }
    }
}
