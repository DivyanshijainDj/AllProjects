using System.Diagnostics;
using System.Threading;
//using ThreadFiles.Staff;

namespace ThreadFiles
{
       

    public class FileOperations
    {
       EmployeeCollection emp = new EmployeeCollection();
        public void TaxClculate()
        {
            for (int i = 0; i <emp.Count; i++)
            {
                emp[i].tax = (emp[i].Salary *2) / 100;
            }

        }

        
        public void WriteData()
        {
            
            foreach(Employee emp in emp)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\coditas\Desktop\Threads\AllData.txt", true)) {
                                     
                    sw.WriteLine($"EmpID : {emp.EmpNo}");
                    sw.WriteLine($"EmpName : {emp.EmpName}");
                    sw.WriteLine($"Department NO:  {emp.DeptNo}");
                    sw.WriteLine($"Designation: {emp.Designation}");
                    sw.WriteLine($"Salary: {emp.Salary}");
                    sw.WriteLine($"Tax: {emp.tax}");
                    sw.WriteLine("---------------");
                }


            }
        }

        public void GeneratePaySlip()
        {

            foreach(Employee em in emp)
            {
                using (StreamWriter sw = new StreamWriter($@"C:\Users\coditas\Desktop\Threads\ {em.EmpNo}.txt", true))
                {
                    

                    sw.WriteLine($"EmpID : {em.EmpNo} \t \t \t Name: {em.EmpName}");
                    sw.WriteLine($"=================================================================");
                    sw.WriteLine($"Department NO:  {em.DeptNo} \t \t Designation: {em.Designation}");
                    sw.WriteLine($"Salary: {em.Salary}  \t \t \t Tax: {em.tax}");
                    sw.WriteLine($"=================================================================");
                    sw.WriteLine($"=================================================================");

                    
                }

            }
        }


    }


    class Program
    {
        static void Main()
        {
            FileOperations fileOperations = new FileOperations();

            Thread t1 = new Thread(new ThreadStart(fileOperations.TaxClculate));
            Thread t2 = new Thread(new ThreadStart(fileOperations.WriteData));
            Thread t3 = new Thread(new ThreadStart(fileOperations.GeneratePaySlip));

            t1.Start();
            t2.Start();
            t3.Start();


            Console.ReadLine();
        }
    }

}
