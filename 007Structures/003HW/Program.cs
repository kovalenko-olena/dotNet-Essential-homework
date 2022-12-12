using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте структуру с именем - Notebook. Поля структуры: модель, производитель, цена.
    В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.*/
namespace _003HW
{
    struct Notebook
    {
        string model;
        string producer;
        decimal price;
        public Notebook(string model, string producer, decimal price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price; 
        }
        public void NotebookInfo()
        {   // Clone the NumberFormatInfo object and create
            // a new object for the local currency
            NumberFormatInfo LocalFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            // Replace the default currency symbol with the local currency symbol.
            LocalFormat.CurrencySymbol = "грн";
            Console.WriteLine($"модель {model}, производитель {producer}, цена {price.ToString("c", LocalFormat)}");
        }
        public void NotebookChange(string model, string producer, decimal price)
        {
            this.model=model;
            this.producer = producer;
            this.price = price;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook=new Notebook("Skoda Kodiaq", "завод “Еврокар” в Соломоново Закарпатской области", 868458);
            notebook.NotebookInfo();
            notebook.NotebookChange("Lada Granta", "завод ЗАЗ в Запорожье", 224790);
            notebook.NotebookInfo();
            notebook.NotebookChange("Renault Arkana", "завод ЗАЗ в Запорожье", 519900);
            notebook.NotebookInfo();

            Console.ReadKey();
        }
    }
}
