using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
/*Требуется описать структуру с именем Worker, содержащую следующие поля:
• фамилия и инициалы работника;
• название занимаемой должности;
• год поступления на работу. 
Написать программу, выполняющую следующие действия:
• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту);
• если значение года введено не в соответствующем формате выдает исключение;
• вывод на экран фамилии работника, стаж работы которого превышает введенное значение. */
namespace _001
{
    struct Worker
    {
        private string fio;
        private string dol;
        private int year;
        public Worker(string fio, string dol, int year)
        {
            this.fio = fio;
            this.dol = dol;
            this.year = year;
        }
        public bool IsStagBigger(int stag)
        {
            if (stag + year < DateTime.Now.Year) return true;
            else return false;
        }
        public string GetFIO()
        {
            return fio;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту)");
            Worker[] worker = new Worker[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("ввод информации о работнике\nфамилия и инициалы работника\t");
                string fio = Console.ReadLine();
                try
                {
                    // если в ФИО нет пробела, т.е. введена только фамилия или имя
                    if (fio.IndexOf(" ") < 0)
                    {
                        fio = "-";
                        throw new MyException(1);
                    }
                    else
                    {
                        // если не по алфавиту
                        if (i >= 1)
                        {
                            if (worker[i - 1].GetFIO() != "")
                            {
                                if (Char.Parse(worker[i - 1].GetFIO().Substring(0, 1)) > Char.Parse(fio.Substring(0, 1)))
                                {
                                    throw new MyException(2);
                                }
                            }
                        }
                    }
                }
                catch (MyException ex) when (ex.Code == 1)
                {
                    Console.WriteLine("EXCEPTION! В ФИО нет пробела");
                }
                catch (MyException ex) when (ex.Code == 2)
                {
                    Console.WriteLine("EXCEPTION! ФИО не упорядочены по алфавиту");
                }

                Console.Write("название занимаемой должности\t");
                string dol = Console.ReadLine();

                Console.Write("год поступления на работу\t");
                string yearStr = Console.ReadLine();
                int year = 0;
                try
                {
                    year = int.Parse(yearStr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEPTION! " + e.Message);
                }
                worker[i] = new Worker(fio, dol, year);
            }


            Console.WriteLine(new String('-', 30));
            Console.WriteLine("вывод на экран фамилии работника, стаж работы которого превышает введенное значение.");
            Console.WriteLine("стаж должен быть больше чем ...");
            string stagStr = Console.ReadLine();
            int stag = 0;
            try
            {
                stag = int.Parse(stagStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION! " + e.Message);
            }
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i].IsStagBigger(stag) == true)
                {
                    Console.WriteLine(worker[i].GetFIO());
                }
            }

            Console.ReadKey();
        }
    }
}
