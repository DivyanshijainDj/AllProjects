// See https://aka.ms/new-console-template for more information

    public class DbCommand
    {
        private  DbConnection _dbConnection;
        private  string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)

                throw new ArgumentException("Null Exception");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction is empty");

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();

            Console.WriteLine("Instruction is : " + _instruction);
        Console.WriteLine();

            _dbConnection.CloseConnection();
        }
    }

