// See https://aka.ms/new-console-template for more information
Console.WriteLine("DB Connection");
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

            if (StartConnection == "start")
            {               
                db.OpenConnection();
            }
            else
            {
                Console.WriteLine("invalid operation");
            }


            Console.WriteLine( "to Close connection enter stop");
            string StopConnection = Console.ReadLine().ToLower();
            db = new SqlConnection(StartConnection);

            if (StopConnection == "stop")
            {
                db.CloseConnection();
            }
            else
            {
                Console.WriteLine("invalid operation");
            }



        }

        if (choice == 2)
        {
            Console.WriteLine("To Open oracle connection enter Start");
            string StartConnection = Console.ReadLine().ToLower();
            db = new SqlConnection(StartConnection);

            if (StartConnection == "start")
            {
                db.OpenConnection();
            }
            else
            {
                Console.WriteLine("invalid operation");
            }

            Console.WriteLine("to Close connection enter stop");
            string StopConnection = Console.ReadLine().ToLower();
            db = new SqlConnection(StartConnection);

            if (StopConnection == "stop")
            {
                db.CloseConnection();
            }
            else
            {
                Console.WriteLine("invalid operation");
            }


        }
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Continue? Press y");
    execution = Console.ReadLine();
} while(execution == "y" || execution == "Y");
Console.ReadLine();

   

