using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for. 
 * С какой проблемой вы столкнулись?*/
namespace _004
{
    /*
      Ответ:
      В ArrayList можно помещать элементы структурного и ссылочного типа
      Но при помещении элемента структурного типа в коллекцию происходит операция boxing, что занимает время
      Без boxing и unboxing можно работать только если будет наполнение только элементами ссылочного типа
     */
    internal class Program
    {
        public const int count = 10000;
        // определить время добавления в ArrayList элементов типа T
        static TimeSpan TimeForAdd<T>(ref ArrayList arrayList, T value)
        {
            DateTime dt1 = DateTime.Now;
            for (int i = 0; i < count; i++)
            {
                arrayList.Add(value);
            }
            DateTime dt2 = DateTime.Now;
            return dt2 - dt1;
        }
        // перебор элементов в ArrayList
        static TimeSpan TimeFor(ref ArrayList arrayList)
        {
            DateTime dt1 = DateTime.Now;
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i]);
            }
            DateTime dt2 = DateTime.Now;
            return dt2 - dt1;
        }

        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
            TimeSpan ts1, ts2, ts3, ts4, ts5;

            ts1 = TimeForAdd<int>(ref list1, 1);
            ts2 = TimeForAdd<int>(ref list2, 1);

            Console.WriteLine("\nFor структурного типа:");
            ts3 = TimeFor(ref list1);

            Console.WriteLine("\nFor ссылочного типа:");
            ts4 = TimeFor(ref list1);
            // в ArrayList, имеющий элементы структурного типа + ссылочный тип
            for (int i = 0; i < count; i++)
            {
                list1.Add("1");
            }
            Console.WriteLine("\nFor структурного+ссылочного типа:");
            DateTime dt5 = DateTime.Now;
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]);
            }
            DateTime dt6 = DateTime.Now;
            ts5 = dt6 - dt5;
            //итоги
            Console.WriteLine($"\n\nAdd структурного типа {ts1.TotalMilliseconds} Milliseconds");
            Console.WriteLine($"Add ссылочного типа {ts2.TotalMilliseconds} Milliseconds");
            Console.WriteLine($"\nПеребор коллекции структурного типа с помощью цикла for занял {ts3.TotalMilliseconds} Milliseconds");
            Console.WriteLine($"Перебор коллекции ссылочного типа с помощью цикла for занял {ts4.TotalMilliseconds} Milliseconds");
            Console.WriteLine($"Перебор коллекции структурного + ссылочного типа с помощью цикла for занял {ts5.TotalMilliseconds} Milliseconds");
                        
            Console.ReadKey();
        }
    }
}
