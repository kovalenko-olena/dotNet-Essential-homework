using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil 
и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 
 */
namespace _003_HW
{
    class ClassRoom
    {
        private List<Pupil> students = new List<Pupil>();

        //конструктор, пользователь может передать 2 или 3 аргумента
        public ClassRoom(List<Pupil> pupil) { students = pupil; }
        
        //info
        public void Info()
        {
            foreach (Pupil student in students)
            {
                student.Study();
                student.Write();
                student.Read();
                student.Relax();
            }
        }
    }
    class Pupil
    {
        public virtual void Study() { Console.Write("I study"); }
        public virtual void Read() { Console.Write("I read"); }
        public virtual void Write() { Console.Write("I write"); }
        public virtual void Relax() { Console.Write("I relax"); }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study() { base.Study(); Console.Write(" excellent!\n"); }
        public override void Read() { base.Read(); Console.Write(" excellent!\n"); }
        public override void Write() { base.Write(); Console.Write(" excellent!\n"); }
        public override void Relax() { base.Relax(); Console.Write(" excellent!\n"); }
    }
    class GoodPupil : Pupil
    {
        public override void Study() { base.Study(); Console.Write(" good!\n"); }
        public override void Read() { base.Read(); Console.Write(" good!\n"); }
        public override void Write() { base.Write(); Console.Write(" good!\n"); }
        public override void Relax() { base.Relax(); Console.Write(" good!\n"); }
    }
    class BadPupil : Pupil
    {
        public override void Study() { base.Study(); Console.Write(" bad!\n"); }
        public override void Read() { base.Read(); Console.Write(" bad!\n"); }
        public override void Write() { base.Write(); Console.Write(" bad!\n"); }
        public override void Relax() { base.Relax(); Console.Write(" bad!\n"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //все ученики
            List<Pupil> people = new List<Pupil>()
            {
            new ExcelentPupil(),
            new GoodPupil(),
            new BadPupil(),
            new GoodPupil()
            };
            //ученики в комнате
            ClassRoom room = new ClassRoom(people.Take(2).ToList());
            //инфо об учениках в комнате
            room.Info();
            Console.ReadKey();
        }
    }
}
