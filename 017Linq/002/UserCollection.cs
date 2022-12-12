using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class UserCollection
    {
        public static IEnumerable Generator()
        {
            yield return new { En = "don't", Rus = "не" };
            yield return new { En = "let", Rus = "позволять" };
            yield return new { En = "go", Rus = "идти" };
            yield return new { En = "never", Rus = "никогда" };
            yield return new { En = "give", Rus = "дайте" };
            yield return new { En = "up", Rus = "вверх" };
            yield return new { En = "it's", Rus = "это" };
            yield return new { En = "such", Rus = "такой" };
            yield return new { En = "wonderful", Rus = "замечательный" };
            yield return new { En = "life", Rus = "жизнь" };
        }
    }
}
