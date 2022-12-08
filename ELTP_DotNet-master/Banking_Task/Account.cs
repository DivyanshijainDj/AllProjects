using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Task
{
    public class Account
    {
        public int AccountNUmber { get; set; }
        public string AccountName { get; set; }
        public decimal OpenBalance { get; set; }
        public string TransacType { get; set; } = string.Empty;
        public decimal TransacAmount { get; set; }
        public decimal NetBalance { get; set; }


    }



  
        

    
}
