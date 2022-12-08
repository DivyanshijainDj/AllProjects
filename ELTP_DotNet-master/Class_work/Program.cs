using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_work;


Console.WriteLine("Using LINQ");


//var person = new { PersonId = 1, PersonName = "MAhesh" };


EmployeeCollection employees = new EmployeeCollection();
DepartmentCollection departments = new DepartmentCollection();

//USing the LINQ Query Approach
 
Console.WriteLine("<============================2nd ques==================>");
Console.WriteLine("");
Console.WriteLine("Maximum Salary Per Department ");
Console.WriteLine();
Console.WriteLine();

var maxsalarydept = (from emp in employees
                     join dep in departments on emp.DeptNo equals dep.Deptno
                     //orderby dep.Deptname ascending
                     orderby dep.Deptno ascending
                     group emp by dep.Deptname into maxsal
                     select new
                     {
                         DeptName = maxsal.Key,
                         emp = maxsal.MaxBy(s => s.Salary),

                     });

foreach (var item in maxsalarydept)
{
    Console.WriteLine(item.emp.DeptNo + "\t\t\t" + item.DeptName + "\t\t\t" + item.emp.EmpName + "\t\t\t" + item.emp.Salary);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<============================3rd ques==================>");
Console.WriteLine("");
Console.WriteLine("Sum of Salary Group by DeptName");
Console.WriteLine();
Console.WriteLine();

var sumlgroupbydeptname = ((from emp in employees
                            join dep in departments on emp.DeptNo equals dep.Deptno
                            group emp by dep.Deptname into deptgroup

                            select new
                            {
                                DeptName = deptgroup.Key,
                                Salary = deptgroup.Sum(e => e.Salary)
                            }).ToList());// COnvert the result into List



foreach (var item in sumlgroupbydeptname)
{
    Console.WriteLine($" DeptName: {item.DeptName} \n Sum of Salaries : {item.Salary}");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<==========================================4th ques ===================>");
Console.WriteLine();
Console.WriteLine();

//var joinQuery = from emp in employees

//                join dep in departments on emp.DeptNo equals dep.Deptno orderby dep.Deptname
//                select new
//                {
//                    EmployeeName = emp.EmpName,
//                    EmployeeID = emp.EmpNo,
//                    DepartmentName = dep.Deptname
//                };


//foreach (var item in joinQuery)
//{

//        Console.WriteLine(item.EmployeeName + "\t\t\t" + item.EmployeeID + "\t\t\t" + item.DepartmentName);


//}


var joinQuery = from emp in employees
                join dep in departments on emp.DeptNo equals dep.Deptno
                orderby dep.Deptname ascending
                group emp by dep.Deptname;

foreach (var item in joinQuery)
{
    Console.WriteLine($"Deptment Name : {item.Key}");
    Console.WriteLine();
    foreach (var detl in item)
    {
        Console.WriteLine($"{detl.EmpName}           EmpID :{detl.EmpNo} ");
    }
    Console.WriteLine();
    Console.WriteLine("<=========================================================>");
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<============================5th ques==================>");
Console.WriteLine();
Console.WriteLine();




var countEmployees = (from emp in employees
                      join dep in departments on emp.DeptNo equals dep.Deptno
                      orderby dep.Deptname ascending
                      group emp by dep.Location into countloc
                      select new
                      {
                          Location = countloc.Key,
                          count = countloc.Count()

                      });
foreach (var item in countEmployees)
{
    Console.WriteLine($" Location: {item.Location} \n employees: {item.count}");
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<============================6th ques==================>");
Console.WriteLine();
Console.WriteLine();

var EmployeeDetail = from emp in employees
                     join dep in departments on emp.DeptNo equals dep.Deptno
                     orderby dep.Deptname ascending
                     group emp by dep.Location;/* into Empdetail
                      select new
                      {
                          Location = Empdetail.Key,
                          temp = Empdetail
                      });*/

foreach (var item in EmployeeDetail)
{
    Console.WriteLine($"location : {item.Key}");
    Console.WriteLine();
    foreach (var detl in item)
    {
        Console.WriteLine($"{detl.EmpName}           EmpID :{detl.EmpNo}      ");
    }
    Console.WriteLine();
}


Console.WriteLine("------------------END OF 1ST AUG ASSIGNMENT----------------------");





//<==========================Print method=============================>
static void Print(IEnumerable<Employee> emps)
{
    foreach (var item in emps)
    {
        Console.WriteLine(item.EmpName);
    }
}

Console.ReadLine();

