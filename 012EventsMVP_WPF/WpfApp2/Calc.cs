using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Calc
    {
        //калькулятор из 6 урока
        public static double Add(params double[] values)
        {
            return values.Sum();
        }
        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(params double[] values)
        {
            return values.Aggregate((p, x) => p *= x);
        }
        public static double Divide(double number1, double number2)
        {
            if (number2 != 0)
                return number1 / number2;
            else
            {
                Console.WriteLine("на ноль делить нельзя");
                return 0;
            }
        }

        public Calc() { }

        public string Clc(string request)
        {
            double result = 0;
            string str = request.Trim();
            char[] oper = { '+', '-', '*', '/' };
            int pos = str.IndexOfAny(oper);
            //отрицат числа в начале строки - не учитываем
            if (pos > 0)
            {
                result = double.Parse(str.Substring(0, pos));
                do
                {
                    if (double.TryParse(str.Substring(pos + 1, str.IndexOfAny(oper, pos + 1) == -1 ? str.Length - pos - 1 : str.IndexOfAny(oper, pos + 1) - pos - 1), out double nextValue))
                    { }
                    else
                    {
                        return 0.ToString();
                    }
                    switch (str.Substring(pos, 1))
                    {
                        case "+":
                            {
                                result = Add(result, nextValue); break;
                            }
                        case "-":
                            {
                                result = Substract(result, nextValue); break;
                            }
                        case "*":
                            {
                                result = Multiply(result, nextValue); break;
                            }
                        case "/":
                            {
                                result = Divide(result, nextValue); break;
                            }
                    }
                    str = str.Substring(pos + 1, str.Length - pos - 1);
                    pos = str.IndexOfAny(oper);
                } while (pos > 0);
            }
            return result.ToString();
        }
    }
}
