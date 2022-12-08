using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Emp_Dept_Relation.Models
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DeptName { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public ICollection<Employee> employees { get; set; }
    }

    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }
        public int Age { get; set; }
        public int DeptNo { get; set; }
        
        public Department department { get; set; }
    }
}
