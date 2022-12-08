using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Technician : Staff
    {
        public string? Specialization { get; set; }
        public int Fees { get; set; }
    }
}
