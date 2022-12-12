using _002Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов. 
    Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. */
namespace _002Project
{
    class MyMatrix
    {
        private int[,] matrix = null;
        private int numberOfRows;
        private int numberOfCols;
        public int NumberOfRows
        {
            get { return numberOfRows; }
        }
        public int NumberOfCols
        {
            get { return numberOfCols; }
        }
        public MyMatrix(int numberOfRows, int numberOfCols)
        {
            if (numberOfRows < 0 || numberOfCols < 0)
            {
                Console.WriteLine("Значения не могут быть отрицательными");
            }
            else
            {
                this.numberOfRows = numberOfRows;
                this.numberOfCols = numberOfCols;
                matrix = new int[numberOfRows, numberOfCols];
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Значения не могут быть отрицательными");
            }
            else
            {
                this.numberOfRows = x;
                this.numberOfCols = y;
                matrix = new int[numberOfRows, numberOfCols];
            }
        }

        public void FeedMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    matrix[i, j] = rnd.Next(1, 9);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /*public int this[int row, int col]
        {
            set
            {
                if ((row > 0 && col > 0) && (row < numberOfRows && col < numberOfCols))
                    matrix[row, col] = value;
                else
                    Console.WriteLine($"Значение не существует, изменений нет");
            }
            get
            {
                return matrix[row, col];
            }
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // Матрица размера m*n, где m - количество строк, n - столбцов
            MyMatrix matrix = new MyMatrix(rnd.Next(3, 7), rnd.Next(3, 7));
            Console.WriteLine("Начальная матрица");
            Console.WriteLine($"Размер:\t строк {matrix.NumberOfRows} столбцов {matrix.NumberOfCols}") ;
            matrix.FeedMatrix();
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Измененная матрица");
            matrix.ChangeMatrix(rnd.Next(3, 7), rnd.Next(3, 7));
            Console.WriteLine($"Размер:\t строк {matrix.NumberOfRows} столбцов {matrix.NumberOfCols}");
            matrix.FeedMatrix();
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 25));

            /*int changeRow = rnd.Next(3, 7);
            int changeCol = rnd.Next(3, 7);
            Console.WriteLine($"Изменяем значение[{changeRow},{changeCol}] в матрице:\nстрока {changeRow + 1} \tстолбец {changeCol + 1}");
            matrix[changeRow, changeCol] = 99;
            matrix.ShowMatrix();*/
            Console.ReadKey();
        }
    }
}
