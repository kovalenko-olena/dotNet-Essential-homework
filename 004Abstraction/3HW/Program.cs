using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Изменить 12 пример первого урока (работа с документом) и создать общий абстрактный класс для всех частей документа
 */
namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
