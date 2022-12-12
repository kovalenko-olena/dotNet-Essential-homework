using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 * Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Book. 
 * При вызове этого метода, производится последовательный поиск строки в книге
 */
namespace _001
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        public Book(string text)
        {
            FindAndReplaceManager.Text = text;
        }
    }
    static class FindAndReplaceManager
    {
        public static string Text { get; set; }
        public static void FindNext(string str)
        {
            if (Text == null)
            {
                Console.WriteLine("Нужно создать книгу!");
            }
            else
            {
                //найти все слова, которые имеют текст str + до и после которого может стоять различное количество символов. 
                //Выражение \w означает алфавитно - цифровой символ, а * после выражения указывает на неопределенное их количество
                Regex regex = new Regex(@"(\w*)" + str + @"(\w*)");
                MatchCollection matches = regex.Matches(Text);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        Console.WriteLine(match.Value);
                }
                else
                {
                    Console.WriteLine("Совпадений не найдено");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //текст в книге
            Book book = new Book("Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа");
            Console.WriteLine("поиск в книге с текстом - " + FindAndReplaceManager.Text);
            //последовательный поиск строки в книге
            FindAndReplaceManager.FindNext("бы");
            Book book1 = new Book("Бык тупогуб, тупогубенький бычок");
            Console.WriteLine("поиск в книге с текстом - " + FindAndReplaceManager.Text);
            FindAndReplaceManager.FindNext("бы");

            Console.ReadKey();
        }
    }
}
