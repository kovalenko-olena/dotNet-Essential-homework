using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс AbstractHandler. В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. Написать программу, 
которая будет выполнять определение документа и для каждого формата должны быть методы
открытия, создания, редактирования, сохранения определенного формата документа. 
 */
namespace _1HW
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Chenge() { Console.WriteLine("Change XMLHandler"); }
        public override void Create() { Console.WriteLine("Create XMLHandler"); }
        public override void Open() { Console.WriteLine("Open XMLHandler"); }
        public override void Save() { Console.WriteLine("Save XMLHandler"); }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Chenge() { Console.WriteLine("Change TXTHandler"); }
        public override void Create() { Console.WriteLine("Create TXTHandler"); }
        public override void Open() { Console.WriteLine("Open TXTHandler"); }
        public override void Save() { Console.WriteLine("Save TXTHandler"); }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Chenge() { Console.WriteLine("Change DOCHandler"); }
        public override void Create() { Console.WriteLine("Create DOCHandler"); }
        public override void Open() { Console.WriteLine("Open DOCHandler"); }
        public override void Save() { Console.WriteLine("Save DOCHandler"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //определение документа
            Console.WriteLine("Введите тип документа \txml\ttxt\tdoc");
            string newDoc = Console.ReadLine().ToLower();
            AbstractHandler handler = null;
            switch (newDoc)
            {
                case "xml":
                    {
                        handler = new XMLHandler();
                        break;
                    }
                case "txt":
                    {
                        handler = new TXTHandler();
                        break;
                    }
                case "doc":
                    {
                        handler = new DOCHandler();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неправильно указан тип документа");
                        break;
                    }
            }
            if (handler != null)
            {
                handler.Create();
                handler.Open();
                handler.Chenge();
                handler.Save();
            }

            Console.ReadKey();
        }
    }
}
