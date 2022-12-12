using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс Book. 
  Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show(). 
  Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
  Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. */
namespace _002_Homework
{
    class Book
    {
        Title title;
        Author author;
        Content content;
        private void InitBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(string title)
        {
            InitBook();
            this.title.GetTitle = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Author
        {
            set
            {
                this.author.GetAutor = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.GetContent = value;
            }
        }
    }
    class Title
    {
        private string title;
        public string GetTitle 
        { 
            get 
            {
                return title ?? "Title is not exist!";
            } 
            set 
            { 
                title = String.IsNullOrEmpty(value)?"-":value; 
            } 
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(GetTitle);
        } 
    }
    class Author
    {
        private string autor;
        public string GetAutor
        {
            get
            {
                return autor ?? "Autor is not exist!";
            }
            set
            {
                autor = String.IsNullOrEmpty(value) ? "-" : value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(GetAutor);
        }
    }
    class Content
    {
        private string content;
        public string GetContent
        {
            get
            {
                return content ?? "Title is not exist!";
            }
            set
            {
                content = String.IsNullOrEmpty(value) ? "-" : value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GetContent);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ///названия книги, имени автора и содержания
            Console.WriteLine("Book Title:");
            Book book = new Book(Console.ReadLine());
            Console.WriteLine("Author:");
            book.Author=Console.ReadLine();
            Console.WriteLine("Content:");
            book.Content=Console.ReadLine();
            book.Show();
            Console.ReadLine();
        }
    }
}
