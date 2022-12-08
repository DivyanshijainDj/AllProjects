using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Models
{

    public class Nurse : Staff
    {
        public string Specialization { get; set; } = String.Empty;
        public int Fees { get; set; }
        


    }
}
