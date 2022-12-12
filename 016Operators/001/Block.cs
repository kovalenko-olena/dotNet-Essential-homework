using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Block
    {
        private int side1 { get; set; }
        private int side2 { get; set; }
        private int side3 { get; set; }
        private int side4 { get; set; }


        public override bool Equals(object obj)
        {
            // If the passed object is null, return False
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not Block Type, return False
            if (!(obj is Block))
            {
                return false;
            }
            return (this.side1 == ((Block)obj).side1)
                && (this.side2 == ((Block)obj).side2)
                && (this.side3 == ((Block)obj).side3)
                && (this.side4 == ((Block)obj).side4);
        }
        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override string ToString()
        {
            return "side #1 = " + side1.ToString() +
                "\tside #2 = " + side2.ToString() +
                "\tside #3 = " + side3.ToString() +
                "\tside #4 = " + side4.ToString();
        }
    }
}
