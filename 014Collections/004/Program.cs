using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию всех четных чисел массива. 
 * Для формирования коллекции используйте оператор yield.*/
namespace _004
{
    static class ListExtentsions
    {
        public static IEnumerable<T> FilterWithYield<T>(this IEnumerable<T> source, Func<T, bool> condition)
        {
            foreach (var item in source)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var reusult = array.FilterWithYield(x => x % 2 == 0);
            foreach (var item in reusult)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
