using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*
 * создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию
 */
namespace _003

{
    public static class ArrayFillShowSort
    {
        public static void FillArray(this int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 30);
            }
        }
        public static void ShowArray(this int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static void Sort(this int[] array)
        {
            Array.Sort(array);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            ArrayFillShowSort.FillArray(myArray);
            Console.WriteLine("Start array:");
            ArrayFillShowSort.ShowArray(myArray);
            Console.WriteLine(new string('-', 30));
            ArrayFillShowSort.Sort(myArray);
            Console.WriteLine("Sort array:");
            ArrayFillShowSort.ShowArray(myArray);

            Console.ReadKey();
        }
    }
}
