// See https://aka.ms/new-console-template for more information
Console.WriteLine("Database Command");
Console.WriteLine();


DbConnection db;


string execution = "y";
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("Select database for connection");
        Console.WriteLine("1. SQL");
        Console.WriteLine("2. Oracle");
        Console.WriteLine();

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("To Open SQl connection enter Start");
            string StartConnection = Console.ReadLine().ToLower();
            db = new SqlConnection(StartConnection);

            

            Console.WriteLine("enter instruction");
            string instruction = Console.ReadLine();
            Console.WriteLine();

            DbCommand dbcommand = new DbCommand(db, instruction);
            dbcommand.Execute();

            



        }

        if (choice == 2)
        {
            Console.WriteLine("To Open oracle connection enter Start");
            string StartConnection = Console.ReadLine().ToLower();
            db = new SqlConnection(StartConnection);


            Console.WriteLine("enter instruction");
            string instruction = Console.ReadLine();
            Console.WriteLine();

            DbCommand dbcommand = new DbCommand(db, instruction);
            dbcommand.Execute();


        }
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Continue? Press y");
    execution = Console.ReadLine();
} while (execution == "y" || execution == "Y");




