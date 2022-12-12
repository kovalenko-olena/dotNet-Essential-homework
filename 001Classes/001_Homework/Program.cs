using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется: Создать класс с именем Rectangle.
В теле класса создать два поля, описывающие длины сторон double side1, side2. 
Создать пользовательский конструктор Rectangle(double side1, double side2), 
в теле которого поля side1 и side2 инициализируются значениями аргументов. 
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() 
и периметр прямоугольника - double PerimeterCalculator(). 
Создать два свойства double Area и double Perimeter с одним методом доступа get. 
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь
 */
namespace _001_Homework
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return (side1 + side2)*2;
        }
        public double Area 
        { 
            get
            {
                return AreaCalculator();
            } 
        }
        public double Perimeter 
        {
            get 
            {
                return PerimeterCalculator();
            } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input side1:\t");
            string sd1=Console.ReadLine();
            Console.Write("Input side2:\t");
            string sd2=Console.ReadLine();
            Rectangle rec=new Rectangle(double.Parse(sd1), double.Parse(sd2));
            Console.WriteLine($"Perimeter: {rec.Perimeter}");
            Console.WriteLine($"Area: {rec.Area}");
            Console.ReadKey();
        }
    }
}
