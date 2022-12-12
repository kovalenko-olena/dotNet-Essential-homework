using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    internal class MyException : Exception
    {
        public int Code { get; }
        public MyException(int code)
        {
            Code = code;
        }
    }
}
