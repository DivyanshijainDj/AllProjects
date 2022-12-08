using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_20
{
    public class Doctor : Staff
    {
        public string? Specialization
        {
            get;

            set;
        }
        public int _Fees = 0;

        public int Fees { 
            get 
            { return _Fees; } 
            set 
            { _Fees = value; } 
        }



        public double GetBasicPay()
        {
            return this.BasicPay;
        }
        public int _income = 0;
    }
}
