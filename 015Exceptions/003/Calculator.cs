using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    static class Calculator
    {
        public static double Add(params double[] values)
        {
            return values.Sum();
        }
        public static double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Mul(params double[] values)
        {
            return values.Aggregate((p, x) => p *= x);
        }
        public static double Div(double number1, double number2)
        {
            try
            {
                if (number2 == 0) throw new DivideByZeroException("на ноль делить нельзя");
                return number1 / number2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
