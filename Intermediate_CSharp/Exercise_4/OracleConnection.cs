// See https://aka.ms/new-console-template for more information
public class OracleConnection : DbConnection
{
    public OracleConnection(string connection)
        : base(connection)
    {
             
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Connection Closed for Oracle..");
        DateTime StopTime = DateTime.Now;
        Console.WriteLine(StopTime);
        Console.WriteLine();
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Connection Openedfor Oracle...");
        DateTime StartTime = DateTime.Now;
        Console.WriteLine(StartTime);
        Console.WriteLine();

    }

}


  