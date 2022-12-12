using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.*/

namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения");
            DateTime dt, dtNext;
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out dt));
            dtNext = new DateTime((DateTime.Now.Year), dt.Month, dt.Day);
            if (DateTime.Now > dtNext) dtNext = new DateTime((DateTime.Now.Year + 1), dt.Month, dt.Day);
            //double days = (dtNext.Date - DateTime.Now.Date).TotalDays;
            TimeSpan timespan = (dtNext - DateTime.Now);
            Console.WriteLine($"Количество дней до следующего дня рождения: {timespan.TotalDays}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
