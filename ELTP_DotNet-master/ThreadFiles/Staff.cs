using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadFiles
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int DeptNo { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }

        public int tax { get; set; }
    }
    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {

            Add(new Employee() { EmpNo = 1001, EmpName = "Yashoda", DeptNo = 1, Salary = 53000, Designation = "Manager", tax=0});
            Add(new Employee() { EmpNo = 1002, EmpName = "DevkiN", DeptNo = 2, Salary = 33000, Designation = "DevOps", tax = 0 });
            Add(new Employee() { EmpNo = 1003, EmpName = "RadheS", DeptNo = 3, Salary = 63000, Designation = "Testing", tax = 0 });
            Add(new Employee() { EmpNo = 1004, EmpName = "Gopal", DeptNo = 4, Salary = 13000, Designation = "DevOps", tax = 0 });
            Add(new Employee() { EmpNo = 1005, EmpName = "Govind", DeptNo = 13, Salary = 93000, Designation = "Manager", tax = 0 });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", DeptNo = 12, Salary = 63000, Designation = "Testing", tax = 0 });
            Add(new Employee() { EmpNo = 1007, EmpName = "Madhav", DeptNo = 11, Salary = 23000, Designation = "HR", tax = 0 });
            Add(new Employee() { EmpNo = 1008, EmpName = "Milind", DeptNo = 15, Salary = 53000, Designation = "HR", tax = 0 });
            Add(new Employee() { EmpNo = 1009, EmpName = "Vasudev", DeptNo = 15, Salary = 63000, Designation = "HR" , tax = 0 });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shrir", DeptNo = 1, Salary = 83000, Designation = "HR" , tax = 0 });
            Add(new Employee() { EmpNo = 1011, EmpName = "Yash", DeptNo = 10, Salary = 53000, Designation = "Manager", tax = 0 });
            Add(new Employee() { EmpNo = 1012, EmpName = "Dev", DeptNo = 2, Salary = 33000, Designation = "Manager", tax = 0 });
            Add(new Employee() { EmpNo = 1013, EmpName = "Radhe", DeptNo = 13, Salary = 63000, Designation = "Manager", tax = 0 });
            //Add(new Employee() { EmpNo = 1014, EmpName = "Gopal", DeptNo = 14, Salary = 13000, Designation = "DevOps" });
            //Add(new Employee() { EmpNo = 1015, EmpName = "Govind", DeptNo = 3, Salary = 93000, Designation = "DevOps" });
            //Add(new Employee() { EmpNo = 1016, EmpName = "ManM", DeptNo = 7, Salary = 63000, Designation = "DevOps" });
            //Add(new Employee() { EmpNo = 1017, EmpName = "Madh", DeptNo = 18, Salary = 23000, Designation = "HR" });
            //Add(new Employee() { EmpNo = 1018, EmpName = "Manshu", DeptNo = 6, Salary = 53000, Designation = "HR" });
            //Add(new Employee() { EmpNo = 1019, EmpName = "Vasu", DeptNo = 6, Salary = 63000, Designation = "HR" });
            //Add(new Employee() { EmpNo = 1020, EmpName = "Shri", DeptNo = 1, Salary = 83000, Designation = "HR" });
            //Add(new Employee() { EmpNo = 1021, EmpName = "Nandan", DeptNo = 8, Salary = 53000, Designation = "Testing" });
            //Add(new Employee() { EmpNo = 1022, EmpName = "Devika", DeptNo = 2, Salary = 33000, Designation = "Testing" });
            //Add(new Employee() { EmpNo = 1023, EmpName = "Shyam", DeptNo = 13, Salary = 63000, Designation = "Testing" });
            //Add(new Employee() { EmpNo = 1024, EmpName = "Geet", DeptNo = 4, Salary = 13000, Designation = "admin" });
            //Add(new Employee() { EmpNo = 1025, EmpName = "Ganesh", DeptNo = 3, Salary = 93000, Designation = "admin" });
            //Add(new Employee() { EmpNo = 1026, EmpName = "Neeti", DeptNo = 2, Salary = 63000, Designation = "admin" });
            //Add(new Employee() { EmpNo = 1027, EmpName = "Shakti", DeptNo = 9, Salary = 23000, Designation = "admin" });
            //Add(new Employee() { EmpNo = 1028, EmpName = "Mukesh", DeptNo = 5, Salary = 53000, Designation = "Analyst" });
            //Add(new Employee() { EmpNo = 1029, EmpName = "Vasa", DeptNo = 5, Salary = 63000, Designation = "Analyst" });
            //Add(new Employee() { EmpNo = 1030, EmpName = "Shivam", DeptNo = 19, Salary = 83000, Designation = "Analyst" });
            //Add(new Employee() { EmpNo = 1031, EmpName = "yatha", DeptNo = 18, Salary = 53000, Designation = "Analyst" });
            //Add(new Employee() { EmpNo = 1032, EmpName = "Divya", DeptNo = 15, Salary = 33000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1033, EmpName = "Rahul", DeptNo = 16, Salary = 63000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1034, EmpName = "gautam", DeptNo = 4, Salary = 13000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1035, EmpName = "Gyani", DeptNo = 13, Salary = 93000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1036, EmpName = "Mohit", DeptNo = 12, Salary = 63000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1037, EmpName = "Milu", DeptNo = 11, Salary = 23000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1038, EmpName = "pawan", DeptNo = 5, Salary = 53000, Designation = "QA" });
            //Add(new Employee() { EmpNo = 1039, EmpName = "divyesh", DeptNo = 5, Salary = 63000, Designation = "R&D Manager" });
            //Add(new Employee() { EmpNo = 1040, EmpName = "roshani", DeptNo = 11, Salary = 83000, Designation = "R&D Manager" });
            //Add(new Employee() { EmpNo = 1041, EmpName = "sahil", DeptNo = 1, Salary = 53000, Designation = "R&D Manager" });
            //Add(new Employee() { EmpNo = 1042, EmpName = "pari", DeptNo = 20, Salary = 33000, Designation = "R&D Manager" });
            //Add(new Employee() { EmpNo = 1043, EmpName = "Rathore", DeptNo = 3, Salary = 63000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1044, EmpName = "Nikh", DeptNo = 4, Salary = 13000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1045, EmpName = "Tribhn", DeptNo = 3, Salary = 93000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1046, EmpName = "Mohit", DeptNo = 12, Salary = 63000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1047, EmpName = "charu", DeptNo = 17, Salary = 23000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1048, EmpName = "NIkita", DeptNo = 15, Salary = 53000, Designation = "SDE" });
            //Add(new Employee() { EmpNo = 1049, EmpName = "Himau", DeptNo = 15, Salary = 63000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1050, EmpName = "bhuresh", DeptNo = 12, Salary = 83000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1051, EmpName = "Santosh", DeptNo = 10, Salary = 53000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1052, EmpName = "Ifham", DeptNo = 12, Salary = 33000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1053, EmpName = "Akshat", DeptNo = 3, Salary = 63000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1054, EmpName = "nishi", DeptNo = 14, Salary = 13000, Designation = "ASE" });
            //Add(new Employee() { EmpNo = 1055, EmpName = "Nidhi", DeptNo = 16, Salary = 93000, Designation = "Manager" });
            //Add(new Employee() { EmpNo = 1056, EmpName = "Yukta", DeptNo = 12, Salary = 63000, Designation = "Manager" });
            //Add(new Employee() { EmpNo = 1057, EmpName = "AAshi", DeptNo = 17, Salary = 23000, Designation = "Manager" });
            //Add(new Employee() { EmpNo = 1058, EmpName = "Yogyata", DeptNo = 15, Salary = 53000, Designation = "Manager" });
            //Add(new Employee() { EmpNo = 1059, EmpName = "Falguni", DeptNo = 5, Salary = 63000, Designation = "Manager" });
            //Add(new Employee() { EmpNo = 1060, EmpName = "Princee", DeptNo = 10, Salary = 83000, Designation = "Manager" });
        }
    }
}