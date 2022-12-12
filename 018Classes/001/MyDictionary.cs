using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _001.Program;

namespace MyDict
{
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
}
