using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс Converter.
    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
    и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – 
    public Converter(double usd, double eur, double rub).
    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
    также программа должна производить конвертацию из указанных валют в гривну. */
namespace _002_HW
{
    class Converter
    {
        float usd;
        float eur;
        float rub;
        public Converter(float usd, float eur, float rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public float MoneyConvert(float money, string val)
        {
            if (val == null || val.Length == 0) return 0;
            switch (val)
            {
                case "usd": return money / usd;
                case "eur": return money / eur;
                case "rub": return money / rub;
                default: return 0;
            }
        }
        public float CurrencyConvert(float money, string val)
        {
            if (val == null || val.Length == 0) return 0;
            switch (val)
            {
                case "usd": return money * usd;
                case "eur": return money * eur;
                case "rub": return money * rub;
                default: return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            float usd=40F;
            float eur=50F;
            float rub=0.01F;
            Converter kurs = new Converter(usd, eur, rub);
            Console.WriteLine("Exchange Rates 1 usd = {0}uah, 1 eur = {1}uah, 1 rub = {2}uah",usd,eur,rub);
            Console.WriteLine("How much <uah> do you have?");
            float money = float.Parse(Console.ReadLine());
            Console.WriteLine("What type of currency(usd, eur, rub) do you want?");
            string val = Console.ReadLine().ToLower();
            Console.WriteLine($"Result: {kurs.MoneyConvert(money, val)}{val}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("How much currency do you have?");
            money = float.Parse(Console.ReadLine());
            Console.WriteLine("What type of currency(usd, eur, rub) do you have?");
            val = Console.ReadLine().ToLower();
            Console.WriteLine($"Result: {kurs.CurrencyConvert(money, val)}uah");
            Console.ReadLine();
        }
    }
}
