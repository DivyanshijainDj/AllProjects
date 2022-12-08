// See https://aka.ms/new-console-template for more information
public abstract class DbConnection
{
    public string ConnectonString;
    public TimeSpan Timeout;

    public DbConnection(String connection)
    {
        if (String.IsNullOrEmpty(connection))
        {
            throw new ArgumentNullException();
        }
       
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();

}


  