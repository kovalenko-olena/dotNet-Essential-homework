using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Создать классы Point и Figure. 
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get. 
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. 
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; 
void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
Написать программу, которая выводит на экран название и периметр многоугольника. 
*/
namespace _003_Homework
{
    class Point
    {
        int x=0;
        int y=0;
        string str1;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Str1 { get { return str1??""; } }

        public Point(int x, int y, string str1)
        {
            this.x = x;
            this.y = y;
            this.str1 = str1;
        }
    }
    class Figure
    {
        Point pointA;
        Point pointB;
        Point pointC;
        Point pointD;
        Point pointE;
        public Figure(Point p1, Point p2, Point p3)
        {
            pointA = p1;
            pointB = p2;
            pointC = p3;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4):this(p1, p2, p3)
        {
            pointD = p4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
        {
            pointE = p5;
        }

        double LengthSide(Point A, Point B)
        {
            //формула расстояния между двумя точками если есть координаты xy для каждой точки
            if (A == null || B == null)
                return 0;
            else if (A.X != B.X || A.Y != B.Y)
                return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            else return 0;
        }
        public void PerimeterCalculator()
        {
            double perimetr;
            perimetr = LengthSide(pointA, pointB)+LengthSide(pointB, pointC)+LengthSide(pointC, pointD)+
                LengthSide(pointD, pointE)+LengthSide(pointE, pointA);
            /*if (pointB==null||pointC==null)
            perimetr = LengthSide(pointA, pointD)+LengthSide(pointD,pointE)+LengthSide(pointE,pointA);*/
            Console.WriteLine($"Perimeter: {perimetr}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1= new Point(3, 1, "A");
            Point point2= new Point(6, 2, "B");
            Point point3= new Point(6, 5, "C");
            //Point point2 = null;
            //Point point3 = null;
            Point point4= new Point(3, 7, "D");
            Point point5= new Point(1, 4, "E");

            Console.Write($"Name: ");
            if (point1 != null)
                Console.Write($"{point1.Str1}");
            if (point2 != null)
                Console.Write($"{point2.Str1}");
            if (point3 != null)
                Console.Write($"{point3.Str1}");
            if (point4 != null)
                Console.Write($"{point4.Str1}");
            if (point5 != null)
                Console.Write($"{point5.Str1}");
            Console.WriteLine();

            //{ point1.Str1+point2.Str1+point3.Str1+point4.Str1+point5.Str1}");
            Figure figure = new Figure(point1, point2, point3, point4, point5);
            figure.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
