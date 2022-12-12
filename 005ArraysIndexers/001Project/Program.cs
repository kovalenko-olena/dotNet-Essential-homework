using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. Вывести наибольшее значение массива, 
наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
 */
namespace _001Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            //Получить случайное число (в диапазоне от 3 до 10)
            int[] array = new int[rnd.Next(3, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(new string('-',25));
            Console.WriteLine($"наибольшее значение массива {array.Max()}");
            Console.WriteLine($"наименьшее значение массива {array.Min()}");
            Console.WriteLine($"общая сумма элементов {array.Sum()}");
            Console.WriteLine($"среднее арифметическое всех элементов {Math.Round(((double)array.Sum() / array.Length),2):n}");
            Console.WriteLine($"все нечетные значения: " );
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"{array[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
