using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3
{
    public abstract class SimpleClass

    {
        public virtual void Test()
        {
            Console.WriteLine("This is the base version of the virtual method");
        }
    }
    public class Derived : SimpleClass

    {
        public override void Test()
        {
            Console.WriteLine("This is the derived version of the virtual method");
        }
    }
}
