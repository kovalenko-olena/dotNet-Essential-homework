using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application.
 * Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую коллекцию автомобилей со следующими данными:
 * марка автомобиля, модель, год выпуска, цвет. А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона. 
 * Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из автомобилей и полную характеристику приобретенной им модели. */
namespace _001
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Построить коллекцию Avto
            var avto = new List<Avto>
            {
                new Avto {Marka = "BMW", Model = "X3",  Year = 2012, Color = "Gray"},
                new Avto {Marka = "BMW",  Model = "X4",    Year = 2020, Color = "Blue"},
                new Avto {Marka = "BMW", Model = "X5",  Year = 2021, Color="Yellow"},
                new Avto {Marka = "BMW",  Model = "X6",    Year = 2022, Color = "Black"},
                new Avto {Marka = "BMW", Model = "X7",  Year = 2018, Color = "Light blue"},
                new Avto {Marka = "BMW",  Model = "X7",    Year = 2016, Color = "Magenta"}
            };
            // Построить коллекцию Customer
            var customer = new List<Customer>
            {
                new Customer {Model="X3", NameCustomer="Petr", Tel="0675438464"},
                new Customer {Model="X4", NameCustomer="Masha", Tel="0675438465"},
                new Customer {Model="X5", NameCustomer="Sophia", Tel="0675438466"},
                new Customer {Model="X6", NameCustomer="Olena", Tel="0675438467"},
                new Customer {Model="X7", NameCustomer="Kostiantyn", Tel="0675438468"},
                new Customer {Model="4 Series Gran Coupe", NameCustomer="Stas", Tel="0675438469"},
            };
            Console.WriteLine("Все покупатели:");
            foreach (var name in customer)
            {
                Console.WriteLine(name.NameCustomer);
            }
            Console.WriteLine("Введите имя интересующего покупателя:");
            string custom = Console.ReadLine();
            // Построить запрос.
            //inner join - нет информации о покупателе, если его модель уже не в базе автотранспорта
            /*var query = from cust in customer
                        join avt in avto
                        on cust.Model equals avt.Model
                        where cust.NameCustomer == custom
                        select new
                        {
                            Name = cust.NameCustomer,
                            Tel = cust.Tel,
                            Model = avt.Model,
                            Marka = avt.Marka,
                            Year = avt.Year,
                            Color = avt.Color

                        };*/

            //left join
            var query = from cust in customer
                        join avt in avto on cust.Model equals avt.Model into gj
                        from sub in gj.DefaultIfEmpty()
                        where cust.NameCustomer == custom
                        select new
                        {
                            Name = cust.NameCustomer,
                            Tel = cust.Tel,
                            Model = sub?.Model ?? string.Empty,
                            Marka = sub?.Marka ?? string.Empty,
                            Year = sub?.Year ?? 0,
                            Color = sub?.Color ?? string.Empty
                        };

            if (query.Count() > 0)
            {
                Console.WriteLine("Информация о покупателе и его машине:");
                foreach (var group in query)
                {
                    Console.WriteLine(group.Name + ", " + group.Tel + ", " + group.Model + ", " + group.Marka + ", " + group.Year + ", " + group.Color);
                }
            }
            else
            {
                Console.WriteLine("not found");
            }
                

            // Delay.
            Console.ReadKey();
        }
    }
}
