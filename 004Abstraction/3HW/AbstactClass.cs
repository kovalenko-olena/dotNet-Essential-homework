using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class AbstactClass
    {
        protected string content;
        public abstract string Content { get; set; }
        public abstract void Show();
    }
}
