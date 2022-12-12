using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Напишите программу, в которой метод будет вызываться рекурсивно. 
 * Каждый новый вызов метода выполняется в отдельном потоке. */
namespace _003
{
    internal class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            //новый поток вызывает Go внутри Go
            Thread t = new Thread(Go);
            t.Name = "Имя потока " + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }

        private static void Main(string[] args)
        {
            Go(20);
            Console.ReadKey();
        }   
    }
}
