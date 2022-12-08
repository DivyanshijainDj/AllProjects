using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    public abstract class SimpleClass
    {

        private void show1()
        {
            Console.WriteLine("This is a private method");
        }
        protected void show2()
        {
            Console.WriteLine("This is a private method");
        }
        /* virtual void Show3()
         {
             Console.WriteLine("This is a private method");
         }
         abstract void show4()
         {
             Console.WriteLine("This is a private method");
         }*/
    }
}
