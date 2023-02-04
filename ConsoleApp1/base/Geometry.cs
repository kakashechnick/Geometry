using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Geometry
    {
        protected abstract int GoTo { get; set; }
        public abstract void prient();
    }
}
