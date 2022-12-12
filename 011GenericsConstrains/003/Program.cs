using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
/* Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его экземпляра 
 * аналогично экземпляру класса ArrayList из пространства имен System.Collections. */

namespace _003
{
    class ArrayList
    {
        object[] arrayList=new object[0];
        public void Add(object value)
        {
            object[] newArrayList = new object[arrayList.Length + 1];
            arrayList.CopyTo(newArrayList, 0);
            arrayList = new object[arrayList.Length+1];
            newArrayList.CopyTo(arrayList, 0);
            arrayList[arrayList.Length-1]=value;
        }
        public int Count
        {
            get
            {
                return arrayList == null ? 0 : arrayList.Length;
            }
        }
        public object this[int index]
        {
            get
            {
                return arrayList[index];
            }
        }
        public int IndexOf(object value)
        {
            for (int i=0; i < arrayList.Length; i++)
            {
                if (arrayList[i] == value) return i;
            }
            return 0;
        }
        public void Reverse()
        {
            object[] newArrayList=new object[arrayList.Length];
            for (int i = 0; i < arrayList.Length; i++)
            {
                newArrayList[i]=arrayList[arrayList.Length-i-1];
            }
            arrayList = new object[arrayList.Length];
            newArrayList.CopyTo(arrayList, 0);
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Add(object value): добавляет в список объект value");
            arrayList.Add(1);
            arrayList.Add(false);
            arrayList.Add("string");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("\nIndexOf(object value): возвращает индекс элемента value");
            Console.WriteLine("IndexOf(string) -> {0}", arrayList.IndexOf("string"));
            Console.WriteLine("\nReverse(): переворачивает список");
            arrayList.Reverse();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.ReadKey();
        }
    }
}
