using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
    В классе Program создайте два метода:  static void ClassTaker(MyClass myClass), 
    который присваивает полю change экземпляра myClass значение «изменено».  
    static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
    Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.
    Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker. 
    Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.
 */
namespace _002HW
{
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    internal class Program
    {

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        //если нужно поменять значение
        //static void StruktTaker(ref MyStruct myStruct)
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change="не изменено";
            myStruct.change="не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            //Структуры хранятся в стеке(тип значений), а классы в куче(ссылочный тип)
            ClassTaker(myClass);//передача по ссылке, значение change будет изменено
            StruktTaker(myStruct);//передача по значению, значение change в структуре myStruct не будет изменено
            //если нужно поменять значение в структуре, то + ref
            //StruktTaker(ref myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadKey();
        }
    }
}
