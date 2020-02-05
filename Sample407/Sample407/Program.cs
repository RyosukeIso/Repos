using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample407
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            IFucs i1 = (IFucs)d;
            IFuncs i2 = (IFuncs)d;
            i1.Func1();
            i1.Func

        }
    }
}
