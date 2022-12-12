using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте структуру описывающую точку в трехмерной системе координат. 
 * Организуйте возможность сложения двух точек, через использование перегрузки оператора +.*/
namespace _004
{
    struct Point
    {
        private int xCoord;
        private int yCoord;
        private int zCoord;
        public Point(int x, int y, int z)
        {
            this.xCoord = x; this.yCoord = y; this.zCoord = z;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.xCoord + p2.xCoord, p1.yCoord + p2.yCoord, p1.zCoord + p2.zCoord);
        }
        public override string ToString()
        {
            return xCoord.ToString() + " * " + yCoord.ToString() + " * " + zCoord.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1, 1);
            Point point2 = new Point(2, 2, 2);
            Point point3 = point1 + point2;
            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());
            Console.WriteLine(point3.ToString());
            Console.ReadKey();
        }
    }
}
