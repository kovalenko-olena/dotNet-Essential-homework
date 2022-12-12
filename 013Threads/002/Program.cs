using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Используя Visual Studio, создайте проект по шаблону Console Application. Расширьте задание 2, так, 
 * чтобы в одном столбце одновременно могло быть две цепочки символов. Смотрите example2.png, представленный как образец. */
namespace _002
{
    class Matrix
    {
        int Len { get; set; }
        int Pos { get; set; }
        object locker1;

        public Matrix(int len, int pos, ref object locker)
        {
            Len = len;
            Pos = pos;
            locker1 = locker;
        }
        static Random random = new Random();
        public static char GetLetter()
        {
            int num = random.Next(0, 26); // Zero to 25
            char let = (num >= 0) ? ((char)('a' + num)) : (char)('a' + num);
            return let;
        }
        public void Text(int posX, int posY, ConsoleColor color, char letter)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(letter);
        }
        public void Write()
        {
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                lock (locker1)
                {
                    Text(Pos, i, ConsoleColor.White, GetLetter());
                    if (i >= 1)
                    {
                        Text(Pos, i - 1, ConsoleColor.Green, GetLetter());
                        if ((i - 2) >= 0)
                        {
                            for (int j = i - 2; (j >= 0) && (j > i - Len); j--)
                            {
                                Text(Pos, j, ConsoleColor.DarkGreen, GetLetter());
                            }
                            //Thread.Sleep(10);
                        }
                    }
                    if (i >= Len)
                    {
                        Console.SetCursorPosition(Pos, i - Len);
                        Console.Write(" ");
                    }
                    if (i == Console.WindowHeight - 1)
                    {
                        for (int j = Console.WindowHeight - Len; j < Console.WindowHeight; j++)
                        {
                            Console.SetCursorPosition(Pos, j);
                            Console.Write(" ");

                            for (int k = j + 1; k < Console.WindowHeight; k++)
                            {
                                Text(Pos, k, ConsoleColor.DarkGreen, GetLetter());
                            }
                            //Thread.Sleep(10);
                        }
                    }
                    if (i == Console.WindowHeight - 1)
                    {
                        i = 0;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            object locker = new object();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Random rand = new Random();
            for(int j = 0; j<2; j++)
            {
                Thread[] threads = new Thread[Console.WindowWidth];
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    threads[i] = new Thread(new ThreadStart(new Matrix(rand.Next(1, Console.WindowHeight / 2), i, ref locker).Write));
                }

                for (int i = 0; i < Console.WindowWidth * 5; i++)
                {
                    int tmp = rand.Next(0, Console.WindowWidth - 1);
                    if (!threads[tmp].IsAlive)
                    {
                        threads[tmp].Start();
                        Thread.Sleep(500);
                    }
                }

                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    if (!threads[i].IsAlive) threads[i].Start();
                    Thread.Sleep(100);
                }
            }

            Console.ReadKey();
        }
    }
}

