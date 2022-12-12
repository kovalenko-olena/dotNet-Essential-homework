using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class Element1
    {
        // Конструктор.
        public Element1(int a)
        {
            Field1 = a;
        }
        public Element1() { }
        // Свойство.
        public int Field1 { get; set; }
    }
}
