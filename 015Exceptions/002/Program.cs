using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Требуется описать структуру с именем Price, содержащую следующие поля: 
 * • название товара; • название магазина, в котором продается товар; • стоимость товара в гривнах. 
 * Написать программу, выполняющую следующие действия: 
 * • ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price 
 * (записи должны быть упорядочены в алфавитном порядке по названиям магазинов); 
 * • вывод на экран информации о товарах,
 * продающихся в магазине, название которого введено с клавиатуры (если такого магазина нет, вывести исключение). */
namespace _002
{
    struct Price
    {
        private string tovar;
        private string magazin;
        private double price;

        public Price(string tovar, string magazin, double price)
        {
            this.tovar = tovar;
            this.magazin = magazin;
            this.price = price;
        }
        public string GetMagazin()
        {
            return magazin;
        }
        public string IsTovarInMagazin(string tovarForSearch)
        {
            if (tovar == tovarForSearch) return magazin;
            else return null;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price\n" +
                "(записи должны быть упорядочены в алфавитном порядке по названиям магазинов)");
            Price[] prices = new Price[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("ввод информации о товаре, магазине, цене\nтовар\t");
                string tovar = Console.ReadLine();

                Console.Write("магазин\t");
                string magazin = Console.ReadLine();
                try
                {
                    if (i >= 1)
                    {
                        if (prices[i - 1].GetMagazin() != "")
                        {
                            if (Char.Parse(prices[i - 1].GetMagazin().Substring(0, 1)) > Char.Parse(magazin.Substring(0, 1)))
                            {
                                throw new MyException(1);
                            }
                        }
                    }
                }
                catch (MyException ex) when (ex.Code == 1)
                {
                    Console.WriteLine("EXCEPTION! Магазины не упорядочены по алфавиту");
                }

                Console.Write("цена\t");
                string priceStr = Console.ReadLine();
                double price = 0;
                try
                {
                    price = int.Parse(priceStr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEPTION! " + e.Message);
                }
                prices[i] = new Price(tovar, magazin, price);
            }

            Console.WriteLine(new String('-', 30));
            Console.WriteLine("введите название товара и получите информацию в каком магазине он есть");
            string tovarForSearch = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i].IsTovarInMagazin(tovarForSearch) != null)
                {
                    Console.WriteLine("магазин " + prices[i].GetMagazin());
                    count++;
                }
            }
            try
            {
                if (count == 0) throw new Exception("товар не найден");
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION! " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
