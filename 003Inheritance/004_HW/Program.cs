using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Создать класс Vehicle. В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
 * Создайте 3 производных класса Plane, Саг и Ship. Для класса Plane должна быть определена высота и количество пассажиров. 
 * Для класса Ship — количество пассажиров и порт приписки. 
 * Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
 */
namespace _004_HW
{
    class Vehicle
    {
        int coordX;
        int coordY;
        decimal price;
        double speed;
        int year;
        public Vehicle(int coordX, int coordY, decimal price, double speed, int year)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void Info()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine(this.GetType());
            Console.WriteLine($"координаты {coordX}\t{coordY}");
            Console.WriteLine($"цена {price}");
            Console.WriteLine($"скорость {speed}");
            Console.WriteLine($"год выпуска {year}");
        }
    }
    class Plane : Vehicle
    {
        int height;
        int pass;
        public Plane(int height, int pass, int coordX, int coordY, decimal price, double speed, int year) : base(coordX, coordY, price, speed, year)
        {
            this.height = height;
            this.pass = pass;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"высота {height}");
            Console.WriteLine($"количество пассажиров {pass}");
        }
    }
    class Car : Vehicle
    {
        public Car(int coordX, int coordY, decimal price, double speed, int year) : base(coordX, coordY, price, speed, year) { }
    }
    class Ship : Vehicle
    {
        int pass;
        int port;
        public Ship(int pass, int port, int coordX, int coordY, decimal price, double speed, int year) : base(coordX, coordY, price, speed, year)
        {
            this.pass = pass;
            this.port = port;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"количество пассажиров {pass}");
            Console.WriteLine($"порт приписки {port}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(2000, 250, 100, 150, 25000, 250, 1984);
            plane.Info();
            Car car = new Car(1500, 5000, 15448, 222, 1999);
            car.Info();
            Ship ship = new Ship(565, 2, 5555, 4000, 2500, 100, 2022);
            ship.Info();
            Console.ReadKey();
        }
    }
}
