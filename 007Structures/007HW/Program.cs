using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*
 Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления. 
Написать программу, выполняющую следующие действия:  ввод с клавиатуры данных в массив, 
состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);  
вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
 */
namespace _001HW
{
    struct Train
    {
        string punkt;
        int nomer;
        DateTime dt;
        public int Nomer { get { return nomer; } }
        public Train(string punkt, int nomer, DateTime dt)
        {
            this.punkt = punkt;
            this.nomer = nomer;
            this.dt = dt;
        }
        public static void InfoTrain(Train train)
        {
            if (train.punkt != null)
            {
                Console.WriteLine("\nназвание пункта назначения: {0}", train.punkt);
                Console.WriteLine("номер поезда {0}", train.nomer);
                //Console.WriteLine($"время отправления {train.dt.ToShortDateString()} в {train.dt.TimeOfDay}");
                Console.WriteLine($"время отправления {train.dt.TimeOfDay}");
            }
        }
    }

    internal class RailwayStation
    {
        public Train[] Trains { get; set; }
        public RailwayStation(Train[] trains)
        {
            this.Trains = trains;
        }
        public static Train InputTrains()
        {
            Console.WriteLine("\nВвод информации о поезде");
            Console.Write("\tназвание пункта назначения - ");
            string punkt = Console.ReadLine();
            Console.Write("\tномер поезда - ");
            if (int.TryParse(Console.ReadLine(), out int nomer) == false)
            { nomer = 0; }
            DateTime dt;
            string input;
            do
            {
                //Console.WriteLine("время отправления в формате dd.MM.yyyy HH:mm:ss ");
                Console.Write("\tвремя отправления в формате HH:mm:ss - ");
                input = Console.ReadLine();
            }
            //while (!DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm:ss", null, DateTimeStyles.None, out dt));
            while (!DateTime.TryParseExact(input, "HH:mm:ss", null, DateTimeStyles.None, out dt));
            return new Train(punkt, nomer, dt);
        }
        public Train this[int number]
        {
            get
            {
                foreach (var item in Trains)
                {
                    if (item.Nomer == number)
                    {
                        return item;
                    }
                }
                Console.WriteLine("таких поездов нет");
                return new();
            }
            set
            {
                Trains[number] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COUNTTRAIL = 8;
            RailwayStation railwayStation = new RailwayStation(new Train[COUNTTRAIL]);
            for (int i = 0; i < COUNTTRAIL; i++)
            {
                railwayStation[i] = RailwayStation.InputTrains();
            }

            Array.Sort(railwayStation.Trains, (x, y) => x.Nomer.CompareTo(y.Nomer));
            Console.WriteLine("\nУпорядоченные поезда:");
            foreach (var item in railwayStation.Trains)
            {
                Train.InfoTrain(item);
            }

            Console.WriteLine("\nВведите номер поезда: ");
            int nomerTrain;
            do
            {
                if (int.TryParse(Console.ReadLine(), out nomerTrain) == false)
                { nomerTrain = 0; }
            }
            while (railwayStation[nomerTrain].Nomer == 0);
            Train.InfoTrain(railwayStation[nomerTrain]);

            Console.ReadKey();
        }
    }
}
