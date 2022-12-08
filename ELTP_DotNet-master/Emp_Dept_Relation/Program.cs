using Emp_Dept_Relation.Models;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("EF Code First");

InfoDbContext ctx = new InfoDbContext();


Department dept = new Department();
dept.DeptNo = 1;
dept.DeptName = "Computer Science";
dept.Location = "Udaipur";

ctx.departments.Add(dept);
ctx.SaveChanges();



Employee emp = new Employee();
emp.EmployeeID = "Emp-01";
emp.EmpName = "divyanshi";
emp.Age = 21;
emp.DeptNo = 1;
ctx.employees.Add(emp);
ctx.SaveChanges();


Console.ReadLine();