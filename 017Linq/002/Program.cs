using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание. */
namespace _002
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (dynamic item in UserCollection.Generator())
            {
                Console.WriteLine("En = {0} \t Rus = {1}", item.En, item.Rus);
            }
            Console.ReadLine();
        }
    }
}
