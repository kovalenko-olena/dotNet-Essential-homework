using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) 
без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе.
 */
namespace _005_HW
{
    class User
    {
        readonly DateTime dt;
        string login;
        string name;
        string fam;
        int age;
        public User(DateTime dt, string login, string name, string fam, int age)
        {
            this.dt = dt;
            this.login = login;
            this.name = name;
            this.fam = fam;
            this.age = age;
        }
        public string UserData() 
        {
            //dt = DateTime.Today;
            return "логин "+ login+", имя "+ name+", фамилия "+fam+", возраст "+Convert.ToString(age)+", дата заполнения анкеты "+dt.ToString(); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User(DateTime.Now, "log", "Petro", "Potapenko", 25);
            Console.WriteLine(newUser.UserData());
            Console.ReadLine();
        }
    }
}
