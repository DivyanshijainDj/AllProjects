using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Models
{
    public class Doctor : Staff
    {
        public string Specialization { get; set; } = String.Empty;
        public int _Fees = 0;

        public int Fees
        {
            get
            { return _Fees; }
            set
            { _Fees = value; }
        }

        public int MaxPatientsPerDay { get; set; }


    }
}
