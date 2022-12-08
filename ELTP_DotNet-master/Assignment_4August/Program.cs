using Assignment_4August;


FileOperation operation = new FileOperation(@"C:\Users\coditas\Desktop\data\StaffData.txt");

try
{

    operation.CreateFile();

    operation.WriteIntoFile(Staffdata.list);

    char ch = 'y';

    Console.WriteLine("------------------CURD Using Files--------------------------");
    Console.WriteLine();

    do
    {
        Console.WriteLine("1.Staff by category");
        Console.WriteLine("2.Search Staff by ID ");
        Console.WriteLine("3.Delete");
        Console.WriteLine("4.Update ");
        Console.WriteLine();
        Console.WriteLine("Chiose option : ");

        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:
                {

                    Console.WriteLine("Enter Category for data fetching");

                    string staffCategory = Console.ReadLine();
                    operation.Read(staffCategory);
                    break;

                }


            case 2:
                {
                    Console.WriteLine("Search By ID");
                    int staffId = Convert.ToInt32(Console.ReadLine());

                    operation.SearchById(staffId);

                    break;

                }


            case 3:
                {
                    Console.WriteLine("Delete by ID");
                    int staffId = Convert.ToInt32(Console.ReadLine());

                    operation.Delete(staffId);

                    break;

                }


            case 4:
                {

                    Console.WriteLine("Update By ID");
                    int staffId = Convert.ToInt32(Console.ReadLine());


                    Staff staff = new Staff();
                   


                    staff.StaffId = staffId;
                    Console.WriteLine("Staff Name :");
                    staff.StaffName = Console.ReadLine();

                    Console.WriteLine("Staff Category :");
                    staff.StaffCategory = Console.ReadLine();

                    Console.WriteLine("Contact Number :");
                    staff.ContactNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Email :");
                    staff.Email = Console.ReadLine();

                    Console.WriteLine("Education :");
                    staff.Education = Console.ReadLine();

                    operation.Update(staffId, staff);


                    break;
                }


            default:
                {
                    Console.WriteLine("Invalid input...!!");
                    break;
                }
        }


        Console.WriteLine("Continue? Press 'y' ");
        ch = Convert.ToChar(Console.ReadLine());
        Console.Clear();
    } while (ch == 'y' || ch == 'Y');


}
catch (Exception e)
{
    Console.WriteLine($"The error is {e.Message}");
}
finally
{
    operation.Dispose();
}