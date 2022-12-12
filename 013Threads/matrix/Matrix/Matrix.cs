using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNS
{
    public class Matrix
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
            int num = random.Next(0, 26); 
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
            for (int i = 0; i < Console.WindowHeight + Len; i++)
            {
                lock (locker1)
                {
                    if (i >= 0 && i < Console.WindowHeight)
                    {
                        Text(Pos, i, ConsoleColor.White, GetLetter());
                        if (i > 1)
                        {
                            Text(Pos, i - 1, ConsoleColor.Green, GetLetter());
                            if ((i - 2) >= 0)
                            {
                                for (int j = i - 2; (j >= 0) && (j > i - Len); j--)
                                {
                                    Text(Pos, j, ConsoleColor.DarkGreen, GetLetter());
                                }
                            }
                        }
                    }
                    if (i >= Len && i < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(Pos, i - Len);
                        Console.Write(" ");
                    }
                    if (i >= Console.WindowHeight)
                    {
                        if (i == Console.WindowHeight - 1)
                            Text(Pos, i - 1, ConsoleColor.Green, GetLetter());
                        else
                        {
                            Console.SetCursorPosition(Pos, i - Len);
                            Console.Write(" ");
                            for (int j = i - Len + 1; j < Console.WindowHeight; j++)
                            {
                                Text(Pos, j, ConsoleColor.DarkGreen, GetLetter());
                            }
                        }
                    }
                    if (i == Console.WindowHeight - 1 + Len)
                    {
                        i = 0;
                    }

                }
            }
        }
    }
}
