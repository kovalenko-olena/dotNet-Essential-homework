using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class Element2
    {
        // Конструктор.
        public Element2(int a)
        {
            Field1 = a;
        }
        public Element2() { }
        // Свойство.
        public int Field1 { get; set; }
    }
}
