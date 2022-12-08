using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    public class SimpleClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Its Show mwthod");
        }

        //public abstract void Show();
    }
    public class Devived : SimpleClass
    {
        protected void inputMethod()
        {
            Show();
        }
    }
}
