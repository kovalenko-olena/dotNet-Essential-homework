using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Используя Visual Studio, создайте проект по шаблону Console Application, требуется cоздать класс DocumentWorker. 
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", 
"Редактирование документа в версии О", "Сохранение документа в версии О".
Создайте производный класс ProDocumentWorker. 
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
Переопределите подходящий способ. При вызове данного метода необходимо выводить на экран документ сохраненный в новом формате.
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), 
если пользователь ввел номера ключа доступа pro и exp, то должен создать экземпляр соответствующей версии класса, 
приведенный к базовому - DocumentWorker.
*/

namespace _005_HW
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument() 
        {
            Console.WriteLine("Редактирование документа в версии О");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа в версии О");
        }

    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер ключа доступа \t");
            string key=Console.ReadLine();
            DocumentWorker worker;
            if (key == "pro")
            {
                Console.WriteLine("предоставлен доступ pro");
                worker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                Console.WriteLine("предоставлен доступ exp");
                worker = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("предоставлен доступ к бесплатной версии");
                worker = new DocumentWorker();
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
    }
}
