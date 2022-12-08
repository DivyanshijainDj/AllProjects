using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Logic
{
    public class Accounts
    {

        public decimal GetStaffIncome(decimal id, StaffLogicAbstract staffLogicAbstract)
        {
            return staffLogicAbstract.getIncomeUsingID(id);
        }

    }
}
