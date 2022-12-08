using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    public abstract class SimpleClass
    {
        static int x = 0;
        static int Test()
        {
            x = 1;
            return x;
        }
        static SimpleClass()
        {
            Console.WriteLine($"{x + 1}");
        }

    }
}
