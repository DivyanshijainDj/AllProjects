using System.IO;
using CS_FirstFile.Operations;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Files");
try
{
    Console.WriteLine();
    Console.WriteLine("Enter directory: " ); 
    string directory = Console.ReadLine();
    //string fileName = "Info.txt";

    
    Console.WriteLine();

    Console.WriteLine("Enter name of the file: ");
    string fileName = Console.ReadLine();
    

    Console.WriteLine();
    Console.WriteLine();

    FileOperation operation = new FileOperation();

    //Methods

    operation.CreateFile(directory, fileName);
    

    operation.WriteFile(directory, fileName, "The First File CReated using the File Class");

    Console.WriteLine();




    var dataFromFile = operation.ReadFile(directory, fileName);
    

    Console.WriteLine($"Initial Data = " + $"{dataFromFile}");

    operation.AppendFile(directory, fileName, "THe Next Data for APpend");
    Console.WriteLine();

    dataFromFile = operation.ReadFile(directory, fileName);

    Console.WriteLine($"Data After Append = " +
        $"{dataFromFile}");
    Console.WriteLine();

    string[] data = new string[] {
      "Line 1","Line 2","Line 3","Line 4"
    };
    operation.AppendFile(directory+ fileName, data);

    dataFromFile = operation.ReadFile(directory, fileName);

    Console.WriteLine($"Data After Appending Array = " +
       $"{dataFromFile}");

    //Copy
    operation.MakeCopy(directory+fileName, @"c:\Coditas\Files\DEstFile.txt");


    //move
    operation.move(directory + fileName, @"c:\Coditas\File\move.txt");


    //encryption
    operation.encrypt(directory+ fileName);

    //decryption
    operation.decrypt(directory + fileName);
    
    //Deleting File
    operation.delete(directory + fileName);





    //operation.decrypt(fileName, @"c:\Coditas\File\decryptFile.txt");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




Console.ReadLine();