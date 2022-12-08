using Stream;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Stream");
FileStreamOperation operation = new FileStreamOperation();
try
{

    operation.CreateFile();

    operation.WriteFile("This file is created using FILESTREAM \n \nUdaipur (pronunciation (help·info)) (ISO 15919: Udayapura), historically named as Udayapura, is a city and municipal corporation in Udaipur district of the state of Rajasthan, India.[3][4] It is administrative headquarter of Udaipur district. It is the historic capital of the kingdom of Mewar in the former Rajputana Agency. It was founded in 1559 by Udai Singh II of the Sisodia clan of Rajput,[5] when he shifted his capital from the city of Chittorgarh to Udaipur after Chittorgarh was besieged by Akbar. It remained as the capital city till 1818 when it became a British princely state,[5] and thereafter the Mewar province became a part of Rajasthan when India gained independence in 1947.[6]. The city is located in the southernmost part of Rajasthan, near the Gujarat border.It is surrounded by the Aravali Range, which separates it from the Thar Desert.It is around 660 km from Delhi, approximately 800 km from Mumbai and 1720 km from Bangalore.Placed almost in the middle of two major Indian metro cities.Besides, connectivity with Gujarat ports provide Udaipur a strategic geographical advantage.[7] Udaipur is well connected with nearby cities and states by means of road, rail and air transportation facilities.The city is served by the Maharana Pratap Airport.Common languages spoken include Hindi, English and Rajasthani(Mewari).");

    
    string str = operation.ReadFile();
    string st = operation.ReadFileline();

    
    Console.WriteLine(str);
    
      
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    operation.Dispose();
}
Console.ReadLine();