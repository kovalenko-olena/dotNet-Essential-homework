using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class DayMonthYear
    {
        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }
        public DayMonthYear(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return "день " + Day.ToString() + " месяц " + Month.ToString() + " год " + Year.ToString();
        }
        public static int operator -(DayMonthYear dt1, DayMonthYear dt2)
        {
            DateTime dtF = new DateTime(dt1.Year, dt1.Month, dt1.Day);
            DateTime dtS = new DateTime(dt2.Year, dt2.Month, dt2.Day);
            TimeSpan ts = dtF - dtS;
            return ts.Days;
        }
        public static DateTime operator +(DayMonthYear dt, int days)
        {
            DateTime dtF = new DateTime(dt.Year, dt.Month, dt.Day);
            dtF = dtF.AddDays(days);
            return dtF;
        }
    }
}
