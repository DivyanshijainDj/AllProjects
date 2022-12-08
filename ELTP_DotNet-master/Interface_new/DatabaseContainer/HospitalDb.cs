using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_new.Models;
using Interface_new.Entities;



namespace Interface_new.DatabaseContainer
{
    public class HospitalDb
    {
        public static Dictionary<string, Staff> GlobalStaffStore = new Dictionary<string, Staff>();
        // public static List<Staff> data = new List<Staff>();
    }
}
