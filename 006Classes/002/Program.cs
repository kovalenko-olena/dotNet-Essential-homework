using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  Расширьте пример урока 005_Book, создав в классе Book, вложенный класс Notes, который позволит сохранять заметки читателя
 */
namespace _002
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        public class Notes
        {
            public List<string> notes = new List<string>();
                
            public void NotesAdd(string note)
            {
                notes.Add(note);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notebook = new Book.Notes();
            notebook.NotesAdd("note1");
            notebook.NotesAdd("note2");
            Console.WriteLine("Your notes in notebook is: ");
            for(int i=0; i<notebook.notes.Count; i++)
            {
                Console.WriteLine(notebook.notes[i]);
            }
            Console.ReadKey();
        }
    }
}
