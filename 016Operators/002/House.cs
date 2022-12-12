using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class House
    {
        public int field1;
        int field2;
        public int Someth1 { get; set; }
        int Someth2 { get; set; }
        public House(int field1, int field2, int someth1, int someth2)
        {
            this.field1 = field1;
            this.field2 = field2;
            Someth1 = someth1;
            Someth2 = someth2;
        }
        public object Clone()
        {
            return (House)this.MemberwiseClone();
        }

        public object DeepClone()
        {
            return new House(field1, field2, Someth1, Someth2) as object;
        }

        public override string ToString()
        {
            return "-> " + field1.ToString() +
                "\t-> " + field2.ToString() +
                "\t-> " + Someth1.ToString() +
                "\t-> " + Someth2.ToString();
        }
    }
}
