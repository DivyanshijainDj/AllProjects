using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
   

    public interface IpersonName
    {
        public void print()
        {
            Console.WriteLine("hello");
        }
    }

    person p = new person();
    public partial class person : IpersonName
    {
    
        
    }
}
