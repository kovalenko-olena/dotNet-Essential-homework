using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс, который будет содержать информацию о дате (день, месяц, год). 
 * С помощью механизма перегрузки операторов, определите операцию разности двух дат (результат в виде количества дней между датами), 
 * а также операцию увеличения даты на определенное количество дней. */
namespace _003
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DayMonthYear dt1 = new DayMonthYear(10, 8, 2020);
            DayMonthYear dt2 = new DayMonthYear(20, 8, 2020);
            Console.WriteLine(dt1.ToString());
            Console.WriteLine(dt2.ToString());
            Console.WriteLine("разность двух дат = " + (dt2 - dt1));
            Console.WriteLine("операция увеличения даты на 5 дней = " + (dt1 + 25).ToString());
            Console.WriteLine("операция увеличения даты на 5 дней = " + (dt2 + 25).ToString());
            Console.ReadLine();

        }
    }
}
