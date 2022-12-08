using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_21.Models;
using Hospital_21.Logic;


namespace Hospital_21.Logic
{
    public class SearchGateway
    {

        public List<Staff> SearchMethod(string Sname)
        {
            return AllStaffDatabase.GlobalDB[Sname];
        }
    }
}
