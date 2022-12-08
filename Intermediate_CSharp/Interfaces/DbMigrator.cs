// See https://aka.ms/new-console-template for more information

public class ConsoleLogger : ILogger
{ 
    public void LogError(string message)
    {
        Console.WriteLine(message);
    }

    public void LogInfo(string message) 
    {
        Console.WriteLine(message);
    }
}


public class DbMigrator
{
    private readonly ILogger _logger;
    public DbMigrator(ILogger logger)
    {
        _logger = logger;   
    }
    public void Migrate()
    {

        _logger.LogInfo("migration started at " + DateTime.Now);


        _logger.LogInfo("migration finished at " + DateTime.Now);

    }
}