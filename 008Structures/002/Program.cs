using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. 
    Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.*/
namespace _002
{
    enum Post
    {
        CEO = 164,
        CFO = 200,
        CIO = 172,
        CTO = 152
    }
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours>(int)worker) return true;
            else return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            
            Console.WriteLine("{0} по норме {0:D} факт 155",Post.CTO);
            if (accountant.AskForBonus(Post.CTO, 155))
                Console.WriteLine("Премия будет");
            else Console.WriteLine("Премии не будет");
            
            Console.WriteLine("{0} по норме {0:D} факт 144",Post.CFO);
            if (accountant.AskForBonus(Post.CFO, 144))
                Console.WriteLine("Премия будет");
            else Console.WriteLine("Премии не будет");
            
            Console.ReadKey();
        }
    }
}
