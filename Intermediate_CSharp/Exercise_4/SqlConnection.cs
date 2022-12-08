// See https://aka.ms/new-console-template for more information
public class SqlConnection : DbConnection
{
    public SqlConnection(string connection)
        : base(connection)
    {
      
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Connection Closed for SQL...");
        DateTime StopTime = DateTime.Now;
        Console.WriteLine(StopTime);
        Console.WriteLine();
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Connection Opened for SQL...");
        DateTime StartTime = DateTime.Now;
        Console.WriteLine(StartTime);
        Console.WriteLine();
    }
}


  