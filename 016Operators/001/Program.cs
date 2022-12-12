using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
 * Equals – способный сравнивать блоки между собой, ToString – возвращающий информацию о полях блока. */
namespace _001
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(5, 8, 9, 10);
            Block block2 = new Block(5, 8, 9, 10);
            Block block3 = new Block(6, 8, 9, 10);
            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());
            Console.WriteLine(block3.ToString());
            Console.WriteLine("Первый Block равен второму Block - " + block1.Equals(block2));
            Console.WriteLine("Второй Block равен третьему Block - " + block2.Equals(block3));
            Console.ReadKey();
        }
    }
}
