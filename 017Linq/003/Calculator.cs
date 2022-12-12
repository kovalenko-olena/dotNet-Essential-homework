using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Calculator
    {
        public dynamic Add(dynamic number1, dynamic number2)
        {
            return number1 + number2;
        }
        public dynamic Sub(dynamic number1, dynamic number2)
        {
            try
            {
                return number1 - number2;
            }
            catch (Exception e) { Console.Write(e.Message + "\t"); return 0; }
        }
        public dynamic Mul(dynamic number1, dynamic number2)
        {
            try
            {
                return number1 * number2;
            }
            catch (Exception e) { Console.Write(e.Message + "\t"); return 0; }
        }
        public dynamic Div(dynamic number1, dynamic number2)
        {
            try
            {
                if (number2 == 0) throw new DivideByZeroException("на ноль делить нельзя");
                try
                {
                    return number1 / number2;
                }
                catch (Exception e) { Console.Write(e.Message + "\t"); return 0; }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }

}
