using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_26.Entities;


namespace Assign_26.Database
{
    public class HospitalDB
    {
        /// <summary>
        /// Global Store
        /// </summary>
        public static Dictionary<String, Staff>? GlobalStaffStore = new Dictionary<string, Staff>();

    }
}
