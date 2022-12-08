using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Models
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
        public int Capacity { get; set; }

    }
}
