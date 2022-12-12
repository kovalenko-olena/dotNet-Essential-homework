using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static _001.CarCollection;
/*Создайте класс CarCollection. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
    Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, 
    индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
    Создайте метод удаления всех машин автопарка. */
namespace _001
{
    // Минимально требуемый интерфейс взаимодействия с экземпляром
    interface ICarCollection
    {
        // метод добавления машин с названием машины и года ее выпуска
        void AddCar(string name, int year);
        //индексатор для получения значения элемента по указанному индексу
        Car this[int index]
        {
            get;
        }
        // свойство только для чтения для получения общего количества элементов
        int CountCarCollection
        {
            get;
        }
    }

    public class CarCollection : ICarCollection
    {
        public class Car
        {
            string NameCar { get; }
            int YearCar { get; }
            public Car(string nameCar, int yearCar)
            {
                NameCar = nameCar;
                YearCar = yearCar;
            }
            public string GetCarInfo()
            {
                return NameCar + " " + YearCar;
            }
        }

        private List<Car> items = new List<Car>();
        public int CountCarCollection
        {
            get
            {
                return items == null ? 0 : items.Count;
            }
        }
        public void AddCar(string name, int year)
        {
            items.Add(new Car(name, year));
        }
        // метод удаления всех машин автопарка
        public void DeleteAllCars()
        {
            items.Clear();
        }
        public Car this[int index]
        {
            get
            {
                return items.ElementAt(index);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection();
            carCollection.AddCar("First Car", 1960);
            carCollection.AddCar("Second Car", 1965);
            carCollection.AddCar("Third Car", 1966);
            carCollection.AddCar("Fourth Car", 1977);
            Console.WriteLine("Количество машин в коллекции - " + carCollection.CountCarCollection);
            Console.WriteLine("Машины:");
            for (int i = 0; i < carCollection.CountCarCollection; i++)
            {
                Console.WriteLine(carCollection[i].GetCarInfo());
            }
            carCollection.DeleteAllCars();
            Console.WriteLine("Автопарк после удаления всех машин");
            for (int i = 0; i < carCollection.CountCarCollection; i++)
            {
                Console.WriteLine(carCollection[i].GetCarInfo());
            }
            Console.WriteLine("Количество машин в коллекции - " + carCollection.CountCarCollection);

            Console.WriteLine(new String('-', 25));
            Console.ReadLine();
        }
    }
}
