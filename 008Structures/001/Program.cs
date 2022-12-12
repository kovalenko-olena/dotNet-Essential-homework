using System;
using static _001.PrintStr;
/*
Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом. 
Используя перечисление, создайте набор цветов, доступных пользователю. 
Ввод строки и выбор цвета предоставьте пользователю. 
*/
namespace _001
{
    static class PrintStr
    {
        public enum ColorsStr
        {
            DarkMagenta,//     Темно-пурпурный цвет (темный фиолетово-красный).
            DarkYellow,//     Темно-желтый цвет (коричнево-желтый).
            Gray,//     Серый цвет.
            DarkGray,//     Темно-серый цвет.
            Blue,//     Синий цвет.
            Green,//     Зеленый цвет.
            Cyan,//     Голубой цвет (сине-зеленый).
            Red,//     Красный цвет.            
            Black,//     Черный цвет.
            DarkBlue,//     Темно-синий цвет.
            DarkGreen,//     Темно-зеленый цвет.
            DarkCyan,//     Темно-голубой цвет (темный сине-зеленый).
            DarkRed,//     Темно-красный цвет.
            Magenta,//     Пурпурный цвет (фиолетово-красный).
            Yellow,//     Желтый цвет.
            White//     Белый цвет.
        }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 0: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case 1: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case 2: Console.ForegroundColor = ConsoleColor.Gray; break;
                case 3: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case 4: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 5: Console.ForegroundColor = ConsoleColor.Green; break;
                case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 7: Console.ForegroundColor = ConsoleColor.Red; break;
                case 8: Console.ForegroundColor = ConsoleColor.Black; break;
                case 9: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case 10: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case 11: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case 12: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case 13: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 14: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 15: Console.ForegroundColor = ConsoleColor.White; break;
            }
            Console.WriteLine(stroka);
        }
        
        // Этот метод выводит детали любого перечисления,
        public static void EvaluateEnum(System.Enum e)
        {
            // Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            // Вывести строковое имя и ассоциированное значение,
            // используя флаг формата D
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Цвет : {0}, Значение: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Выберите цвет и введите соответствующее значение: ");
            ColorsStr e2 = ColorsStr.Black;
            EvaluateEnum(e2);

            int.TryParse(Console.ReadLine(),out int color);
            Print(str,color);
            Console.ReadLine();
        }
    }
}
