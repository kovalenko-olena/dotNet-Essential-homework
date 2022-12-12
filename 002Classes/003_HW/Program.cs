using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*
 Создать класс Employee. В теле класса создать пользовательский конструктор, 
который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника. 
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор. Написать программу, 
которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор. */
namespace _003_HW
{
    class Employee
    {
        string name;
        string fam;
        const double taxPer = 0.15;
        private double Oklad { get; set; }
        private double Tax { get; set; }

        public Employee(string name, string fam) { this.name = name; this.fam = fam; }

        private void OkladClc(string dol, double stg)
        {
            switch (dol)
            {
                case "boss": Oklad=10000;
                    break;
                case "worker": Oklad=6000;
                    break;
                case "bux": Oklad=8000;
                    break;
                default: Oklad=0;
                    break;
            }
            if (stg >= 5&&stg<10) Oklad += 1000;
            if (stg >= 10) Oklad += 2000;
            Tax = Oklad * taxPer;
        }
        public void Info(string dol, double stg)
        {
            OkladClc(dol,stg);
            Console.WriteLine($" фамилия - {fam}, имя - {name}, должность - {dol}, оклад {Oklad} и налоговый сбор {Tax}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Petro", "Puzenko");
            emp.Info("boss", 10);
            
            Console.ReadLine();
        }
    }
}
