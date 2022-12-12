using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Создать класс Article, содержащий следующие закрытые поля:
• название товара;
• название магазина, в котором продается товар;
• стоимость товара в гривнах. Создать класс Store, содержащий закрытый массив элементов типа Article. Обеспечить следующие возможности:
• вывод информации о товаре по номеру с помощью индекса;
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, 
выдать соответствующее сообщение; Написать программу, вывода на экран информацию о товаре. 
*/

namespace _003Project
{
    class Article
    {
        private string name;
        private string store;
        private decimal price;
        public string Name { get { return name; }}
        public Article(string name, string store, decimal price)
        {
            this.name = name;
            this.store = store;
            this.price = price;
        }
        public string InfoArticle()
        {
            // Clone the NumberFormatInfo object and create
            // a new object for the local currency
            NumberFormatInfo LocalFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            // Replace the default currency symbol with the local currency symbol.
            LocalFormat.CurrencySymbol = "грн";
            return $"Товар: {name}, \tМагазин: {store}, \tЦена: {price.ToString("c", LocalFormat)}";
        }
    }
    class Store
    {
        private Article[] articles;
        public Store(Article[] articles)
        {
            this.articles = articles;
        }
        public Article this[int number]
        {
            get
            {
                return articles[number];
            }
        }
        public Article this[string text]
        {
            get
            {
                foreach (var item in articles)
                {
                    if (item.Name == text)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Article[] articles = new Article[3];
            articles[0] = new Article("About War", "Srore#1", 2500);
            articles[1] = new Article("1984", "Store#1", 2000);
            articles[2] = new Article("1966", "Store#1", 2001);

            Store store = new Store(articles);
            Console.WriteLine("вывод информации о товаре по номеру с помощью индекса");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(store[i].InfoArticle());
                Console.WriteLine(new string ('-',55));
            }
            Console.WriteLine("введите название товара");
            string str = Console.ReadLine();
            Console.WriteLine(store[str]==null?"нет товара с таким названием":store[str].InfoArticle());
            Console.ReadKey();
        }
    }
}
