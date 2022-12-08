using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Logic
{
    public abstract class StaffLogicAbstract
    {
        public abstract decimal getIncomeUsingID(decimal id);
        public abstract decimal TaxforIncome(decimal income);

    }
}
