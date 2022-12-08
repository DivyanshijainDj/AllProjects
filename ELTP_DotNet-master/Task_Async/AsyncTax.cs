public class Asynctax
{
    static object locked = new object();
    public async Task CalculateTaxAsync(Employee emp)
    {
        emp.TDS = emp.Salary * Convert.ToDecimal(0.1);
        //EmployeeList.l1.Remove(emp);
    }
    public static void WriteFile(Employee emp)
    {
        try
        {
            Monitor.Enter(locked);
            using (StreamWriter sw = new StreamWriter($@"C:\Users\coditas\Desktop\ThreadAsync\{emp.EmpName}.txt", true))
            {
                sw.WriteLine($"Emp Name: {emp.EmpName}\nEmp No:  {emp.EmpNo}");
                sw.WriteLine("===============================================");
                sw.WriteLine("===============================================");

                sw.WriteLine($"Salary:  {emp.Salary}\nTDS:    {emp.TDS}");
                sw.WriteLine("===============================================");
                sw.WriteLine("===============================================");

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:  {ex.Message}");
        }
        finally
        {
            Monitor.Exit(locked);
        }
    }
    public static void WriteAllFile(Employee emp)
    {
        try
        {
            Monitor.Enter(locked);
            using (StreamWriter sw = new StreamWriter($@"C:\Users\coditas\Desktop\ThreadAsync\All.txt", true))
            {
                sw.WriteLine($"Emp Name: {emp.EmpName}      Salary:   {emp.Salary} TDS :   {emp.TDS}");
                sw.WriteLine("===============================================");

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:  {ex.Message}");
        }
        finally
        {
            Monitor.Exit(locked);
        }
    }
}
