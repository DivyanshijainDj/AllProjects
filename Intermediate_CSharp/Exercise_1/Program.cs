// See https://aka.ms/new-console-template for more information

//--------------------------Stopwatch--------------------------------

Stopwatch stopwatch = new Stopwatch();


string? continueExecution = "y";
do
{
    Console.WriteLine("StopWatch");
    Console.WriteLine();

    Console.WriteLine("Enter 'Start' to Start the stopwatch");
    Console.WriteLine("=======================================================");


    String InputStart = Console.ReadLine().ToLower();

    if (String.IsNullOrEmpty(InputStart))
    {
        Console.WriteLine("Didn't press anything, Try again");
        break;
    }

    if (InputStart == "start")
    {
        stopwatch.Start();
    }
    else
    {
        Console.WriteLine("Invalid operation !");
    }

    Console.WriteLine("Enter 'Stop' to Stop the stopwatch");
    String InputStop = Console.ReadLine().ToLower();

    Boolean perform = false;
    do
    {
        if (String.IsNullOrEmpty(InputStop))
        {
            perform = true;
        }
        else
        {
            perform = false;
        }
    } while (perform);

    if (InputStop == "stop")
    {
        stopwatch.Stop();
    }
    else
    {
        Console.WriteLine("invalid operation");
    }


    stopwatch.difference();



    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
    Console.Clear();
} while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();



