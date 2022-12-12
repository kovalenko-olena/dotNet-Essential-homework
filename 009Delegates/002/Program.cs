using System;
/*Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов,
    сообщенных с делегатами в массиве. 
    Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. */
namespace _002
{
    public delegate double myDelegate(myDelegateArray[] myDelegates);
    public delegate int myDelegateArray();
    internal class Program
    {
        static void Main(string[] args)
        {
            //массив делегатов
            myDelegateArray[] myDelegateArrays = new myDelegateArray[]
            {
                delegate ()
                {
                    Random random = new Random(); return random.Next(0, 5);
                },
                delegate ()
                {
                    Random random = new Random(); return random.Next(6, 10);
                },
                delegate ()
                {
                    Random random = new Random(); return random.Next(11, 15);
                },
            };

            //вывод массива делегатов
            Console.WriteLine("Массив случайных значений типа int:");
            for (int i = 0; i < myDelegateArrays.Length; i++)
            {
                Console.WriteLine(myDelegateArrays[i].Invoke());
            }

            //среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве
            myDelegate myDelegateSr = delegate (myDelegateArray[] myDelegates)
            {
                double res = 0;
                for (int i = 0; i < myDelegates.Length; i++)
                {
                    res += myDelegates[i].Invoke();
                }
                return res / myDelegates.Length;
            };

            Console.WriteLine("Cреднее арифметическое: {0:f2}", myDelegateSr(myDelegateArrays));

            Console.ReadKey();
        }
    }
}
