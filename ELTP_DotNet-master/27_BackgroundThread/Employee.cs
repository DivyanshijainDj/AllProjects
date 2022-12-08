using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_BackgroundThread
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptNo { get; set; }
        public string Designation { get; set; }
    }

    public class EmployeeData : Dictionary<int, Employee>
    {
       public EmployeeData()
        {
            Add(1, new Employee() { Id = 1, DeptNo = 1, Designation = "developer", Name = "divyanshi" });
            Add(2, new Employee() { Id = 2, DeptNo = 2, Designation = "manager", Name = "sanidhya" });
            Add(3, new Employee() { Id = 3, DeptNo = 3, Designation = "intern", Name = "princee" });
        }
    }
}

