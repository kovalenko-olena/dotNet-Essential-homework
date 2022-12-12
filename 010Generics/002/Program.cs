using System;
using System.Collections.Generic;
/*Создайте проект Console Application, в котором реализуйте типизированный класс "Волшебный мешок". 
    Волшебство  заключается в том, что подарок сам появляется в мешке и зависит от того, кто пытается открыть мешок. 
    Причем подарок для одного существа может появиться только 1 раз в день. 
    Используйте ограничения типа - интерфейс со свойством, хранящим тип существа, которое пытается получить подарок из мешка.*/
namespace _002
{
    //интерфейс хранит тип существа(кот и хомяк)
    interface IAnimal<T>
    {
        T TypeAnimal { get; set; }
    }
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
    }
    //типы существ - кот и хомяк
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
    }
    class Humster : Animal
    {
        public Humster(string name) : base(name)
        {
        }
    }
    //типы подарков
    class Gift
    {
        private string[] typeGift;
        public string TypeGift { get; set; }
        public Gift(string typeGift)
        {
            TypeGift = typeGift;
        }
        public string this[int index]
        {
            get
            {
                return typeGift[index];
            }
            set
            {
                typeGift[index] = value;
            }
        }
    }
    //волшебный мешок, реализует интерфейс тип существа
    //T - тип существа
    //G - тип подарка
    class Magic<T, G> : IAnimal<T>
    {
        public T TypeAnimal { get; set; }
        private DateTime dt;
        public Dictionary<T, DateTime?> dictionary = new Dictionary<T, DateTime?>();
        private G[] arrGifts;
        public G Gift(ref G gift)
        {
            if (arrGifts == null) { Console.WriteLine("Подарков нет"); }
            else
            {
                if (TypeAnimal is Cat)
                {
                    gift = arrGifts[0];
                }
                else
                {
                    gift = arrGifts[arrGifts.Length - 1];
                }
            }
            return gift;
        }
        public Magic(G[] arrGifts)
        {
            this.arrGifts = arrGifts;
        }

        public int GiveMeGift(ref G gift)
        {
            //если существо ранее не брало подарок или брало в другую дату, то даем подарок
            if (dictionary[TypeAnimal] == null || dictionary[TypeAnimal] != dt)
            {
                dictionary[TypeAnimal] = dt;
                Gift(ref gift);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void SetAnimal(DateTime dt, T typeAnimal)
        {
            this.dt = dt;
            TypeAnimal = typeAnimal;
            //если существо никогда не брало подарок
            if (dictionary.ContainsKey(TypeAnimal) == false)
                dictionary[TypeAnimal] = null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //подарки
            Gift[] gifts = new Gift[4];
            gifts[0] = new Gift("Еда");
            gifts[1] = new Gift("Игрушка");
            gifts[2] = new Gift("Погремушка");
            gifts[3] = new Gift("Ерундушка");
            Console.WriteLine("Список подарков: ");
            foreach (Gift i in gifts)
            {
                Console.WriteLine(i.TypeGift);
            }

            //создаем 2 существа - кота и хомяка
            Animal cat = new Cat("Васька");
            Animal humster = new Humster("АмНям");

            //создаем мешок, из которого существа могут тянуть подарки
            Magic<Animal, Gift> magic = new Magic<Animal, Gift>(gifts);

            //подарок
            Gift giftForCat = null;
            Gift giftForHumster = null;
            int result;

            //кот открывает мешок
            Open(cat, DateTime.Now.Date, ref giftForCat);
            //существо снова хочет вытянуть что-то из мешка в тот же день
            Open(cat, DateTime.Now.Date, ref giftForCat);
            //существо в третий раз пытается вытянуть из мешка подарок, но в другой день
            Open(cat, new DateTime(2023, 1, 1), ref giftForCat);
            //и снова попытка вытянуть из мешка подарок в тот же день
            Open(cat, new DateTime(2023, 1, 1), ref giftForCat);

            //хомяк открывает мешок
            Open(humster, DateTime.Now.Date, ref giftForHumster);
            Open(humster, DateTime.Now.Date, ref giftForHumster);
            Open(humster, new DateTime(2023, 1, 1), ref giftForHumster);

            void Open(Animal animal, DateTime dt, ref Gift gift)
            {
                Console.WriteLine(new string('-', 30));
                magic.SetAnimal(dt, animal);
                result = magic.GiveMeGift(ref gift);
                if (result != 0) Console.WriteLine($"<{animal.Name}> {dt:dd.MM.yyyy} получает подарок {gift.TypeGift}");
                else Console.WriteLine($"ай яй яй <{animal.Name}>, нельзя два раза за день {dt:dd.MM.yyyy} брать подарки");
            }
            Console.ReadKey();
        }
    }
}
