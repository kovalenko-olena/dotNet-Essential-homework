using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Создать класс с именем Address. 
В теле класса требуется создать поля: index, country, city, street, house, apartment. 
Для каждого поля, создать свойство с двумя методами доступа. 
Создать экземпляр класса Address. 
В поля экземпляра записать информацию о почтовом адресе. 
Выведите на экран значения полей, описывающих адрес.
*/
namespace _004_Homework
{
    class Address
    {
        string index;
        string country;
        string city;
        string street;
        string house;
        int apartment;
        public string Index { get { return index; } set { index = value; } }
        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string House { get { return house; } set { house = value; } }
        public int Apartment { get { return apartment; } set { apartment = value; } }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "0524";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Street";
            address.House = "1a";
            address.Apartment = 2254;
            Console.WriteLine($"Adress:\n{address.Index}, {address.Country}, {address.City}, " +
                $"{address.Street}, {address.House}, {address.Apartment}");
            Console.ReadLine();
        }
    }
}
