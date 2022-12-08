using Aug4_files;

Console.WriteLine("                 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Aug 4 files assignment~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine();

functions fun = new functions();
string? continueExecution = "y";
do
{
    Console.WriteLine("Enter your choice to perform operation");
    Console.WriteLine("===========================================================================");
    Console.WriteLine();

    Console.WriteLine("1. Get Deatils of particular File.");
    Console.WriteLine("2. Image to Byte Array.");
    Console.WriteLine("3. Files from Directory and Sub-Directory.");
    Console.WriteLine("4. Copy Files from one Directory to another.");


    Console.WriteLine();


    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (choice)

    {
        case 1:

            {
                string path = @"C:\Users\coditas\Desktop\data";
                functions.GetDetails(path);
                break;
                
            }

            
        case 2:
            {
                functions.imageConversion(@"C:\Users\coditas\Desktop\husky.jpg");
                break;
                                
            }

        case 3:
            {
                functions.GetFiles();
                break;
            }


            case 4:
            {
                functions.CopyFiles();
                break;
            }
    }

    Console.WriteLine("Please enter y or Y to continue");
            continueExecution = Console.ReadLine();
    Console.Clear();
}while (continueExecution == "y" || continueExecution == "Y");









