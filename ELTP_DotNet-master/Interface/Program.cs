// See https://aka.ms/new-console-template for more informatio
using Interface;
using Interface.Entity;
using Interface.Model;

Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Driver driver = new Driver();

IOperations<Doctor, int> Odoc = new DoctorLogic();
IOperations<Nurse, int> ONur = new NurseLogic();
IOperations<Driver, int> ODr = new DriverLogic();


EventListener eventListener2 = new EventListener(ONur);
EventListener eventListener1 = new EventListener(Odoc);
EventListener eventListener3 = new EventListener(ODr);

char choice;
do
{
    List<String> StaffData = new List<string>();

    Console.WriteLine("<============================Enter Choice===============================> ");
    Console.WriteLine();
  
    Console.WriteLine("1.Register Staff");
    Console.WriteLine("2.Update Staff");
    Console.WriteLine("3.Delete Staff ");
    Console.WriteLine("4.Get All Staff");
    Console.WriteLine("5.Get Staff by ID");
    Console.WriteLine("6. Salary of Staff");
    Console.WriteLine();

    Console.WriteLine("=====================================================================================");
    int UserChoice = Convert.ToInt32(Console.ReadLine());
    switch (UserChoice)
    {
        case 1:
            {

                Console.WriteLine("Enter the Details in Following order\n");
                Console.WriteLine("StaffId  StaffName   City   Education  BasicPay   StaffCategory");
                int id = Convert.ToInt32(Console.ReadLine());
                while (GlobalIdStore.StaffIdStore.Contains(id))
                {
                    Console.WriteLine("Id Already Exist, Try another");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                StaffData.Add(Convert.ToString(id));
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                String LStaffCategory = Console.ReadLine();
               

                if (LStaffCategory == "doctor")
                {
                    RegisterDoctor(doctor, StaffData, Odoc);

                }
                else if (LStaffCategory == "nurse")
                {
                    RegisterNurse(nurse, StaffData, ONur);

                }
                else if (LStaffCategory == "driver")
                {
                    RegisterDriver(driver, StaffData, ODr);
                }
                else
                {
                    Console.WriteLine("Invalid Staff");
                }
                break;
            }

        case 2:
            {
                Console.WriteLine(" Details to Update \n");
                Console.WriteLine("StaffId  StaffName   City   Education  BasicPay   StaffCategory");
                int id = Convert.ToInt32(Console.ReadLine());
                StaffData.Add(Convert.ToString(id));
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                String LStaffCategory = Console.ReadLine();
                

                if (LStaffCategory == "doctor")
                {
                    UpdateDoctor(doctor, StaffData, Odoc);

                }
                else if (LStaffCategory == "nurse")
                {
                    UpdateNurse(nurse, StaffData, ONur);

                }
                else if (LStaffCategory == "driver")
                {
                    UpdateDriver(driver, StaffData, ODr);
                }
                else
                {
                    Console.WriteLine("Invalid Staff");
                }
                break;
                
            }

        case 3:
            {
                Console.WriteLine("<==============Choose Category====================>");
                Console.WriteLine("1. Delete Docotr");
                Console.WriteLine("2. Delete Nurse");
                Console.WriteLine("3. Delete Driver");

                int Delchoice = Convert.ToInt32(Console.ReadLine()) ;

                if (Delchoice == 1)
                {
                    Console.WriteLine("Doctor Id to Delete ");
                    int Localid = Convert.ToInt32(Console.ReadLine());

                    
                    ShowDoctorDetails(Odoc.Delete(Localid));
                    
                }
                else if (Delchoice == 2)
                {
                    Console.WriteLine("Nurse Id to Delete");
                    int Localid = Convert.ToInt32(Console.ReadLine());

                    ShowNurseDetails(ONur.Delete(Localid));
                }
                else if (Delchoice == 3)
                {
                    Console.WriteLine("Driver Id to Delete");
                    int Localid = Convert.ToInt32(Console.ReadLine());
                    ShowDriverDetails(ODr.Delete(Localid));
                }
                break;
            }

        
        case 4:
            {
                Console.WriteLine("<==============Choose Category====================>");
                Console.WriteLine("1. Get Doctor");
                Console.WriteLine("2. Get Nurse");
                Console.WriteLine("3. Get Driver");

                int GetStaff = Convert.ToInt32(Console.ReadLine());

                if (GetStaff == 1)
                {
                    var res = Odoc.GetAll();
                    foreach (var item in res)
                    {
                        ShowDoctorDetails(item);
                    }

                }
                else if (GetStaff == 2)
                {
                    var res = ONur.GetAll();
                    foreach (var item in res)
                    {
                        ShowNurseDetails(item);
                    }
                }
                else if (GetStaff == 3)
                {
                    var res = ODr.GetAll();
                    foreach (var item in res)
                    {
                        ShowDriverDetails(item);
                    }
                }
                break;
               

            }

        

        case 5:
            {
                Console.WriteLine("<==============Choose Category====================>");
                Console.WriteLine("1. Get Docotr");
                Console.WriteLine("2. Get Nurse");
                Console.WriteLine("3. Get Driver");

                int IdChoice = Convert.ToInt32(Console.ReadLine());

                if (IdChoice == 1)
                {
                    Console.WriteLine("Get Doctor Record");
                    int Localid = Convert.ToInt32(Console.ReadLine());
                    ShowDoctorDetails(Odoc.Get(Localid));

                }
                else if (IdChoice == 2)
                {
                    Console.WriteLine("Get Nurse Record");
                    int Localid = Convert.ToInt32(Console.ReadLine());
                    ShowNurseDetails(ONur.Get(Localid));
                }
                else if (IdChoice == 3)
                {
                    Console.WriteLine("Get driver Record");
                    int Localid = Convert.ToInt32(Console.ReadLine());
                    ShowDriverDetails(ODr.Get(Localid));
                }
                break;

                
            }

        
        case 6:
            {
                
                Console.WriteLine("<=======================CHOOSE CATEGORY==============================>");
                Console.WriteLine(" 1. Doctor");
                Console.WriteLine(" 2. Nurse");
                Console.WriteLine(" 3. Driver");
                int salCal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter StaffID");
                int Salaryid = Convert.ToInt32(Console.ReadLine());

                if (salCal == 1)
                {
                    DisplaySalaryOfDoctor(Salaryid, Odoc);
                }
                else if (salCal == 2)
                {
                    DisplaySalaryOfNurse(Salaryid, ONur);
                }
                else if (salCal == 3)
                {
                    DisplaySalaryOfDriver(Salaryid, ODr);
                }
                else
                {
                    Console.WriteLine("Invalid Choice..");
                }
                break;
            }

    }


    Console.WriteLine("Wanna perform any other operation");
    choice = Convert.ToChar(Console.ReadLine());
    choice = Char.ToLower(choice);
    Console.Clear();
} while (choice == 'y');


static void DisplaySalaryOfDoctor(int ID, IOperations<Doctor, int> Odoc)
{
    WordsToDigits wordGenerator = new WordsToDigits();
    if (Odoc.Salary(ID) != null)
    {
        var res = Odoc.Salary(ID);

        Console.WriteLine("===============================================================================================");
        Console.WriteLine("\t\t\t\tStaff Details");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($"\n Staff Name : {res[0]} \t\t Staff Id : {ID} \t\t StaffType : Doctor");
        Console.WriteLine( );

        Console.WriteLine("===============================================================================================");
        Console.WriteLine(" \t\t\t\t Income Details  ");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Basic Pay : In Digit :  Rs.{res[1]} ");
        
        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[1]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Gross Income :In Digit :  Rs.{res[2]} ");
        
        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Tax Paid :In Digit :  Rs.{res[3]} ");
        
        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
        Console.WriteLine();

        Console.WriteLine(" Net Income : ");
        Console.WriteLine($" In Digit :  Rs.{Convert.ToInt32(res[2]) - Convert.ToInt32(res[3])}");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]) - Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
    }
    else
    {
        Console.WriteLine("Sorry, You have entered Invalid ID");
    }
}



static void RegisterDoctor(Doctor doctor, List<string> StaffDataList, IOperations<Doctor, int> Odoc)
{

    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("Specialization   Fees   MaxPatientsPerDay");

    doctor = new Doctor()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        Specilization = Console.ReadLine(),
        Fees = Convert.ToInt32(Console.ReadLine()),
        MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine()),
    };


    Odoc.Create(doctor);

}

static void RegisterNurse(Nurse nurse, List<string> StaffDataList, IOperations<Nurse, int> ONur)
{
    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("Experience   NoOfRoomsVisitedPerDay");

    nurse = new Nurse()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        Experience = Convert.ToInt32(Console.ReadLine()),
        NoofRoomsVisitedPerDay = Convert.ToInt32(Console.ReadLine()),

    };

    ONur.Create(nurse);
}

static void RegisterDriver(Driver driver, List<string> StaffDataList, IOperations<Driver, int> ODr)
{
    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("VehicleTYpe   NoofTripsPerDay");

    driver = new Driver()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        VehicleType = Console.ReadLine(),
        NoOfTripsPerDay = Convert.ToInt32(Console.ReadLine()),

    };

    ODr.Create(driver);



}
static void ShowDoctorDetails(Doctor item)
{
    if (item != null)
        Console.WriteLine($"\nStaffID  : {item.StaffId},        StaffName : {item.StaffName},       City : {item.City},       Education : {item.Education},       MaxPatientsPerDay : {item.MaxPatientsPerDay},       Fees : {item.Fees}");

}
static void ShowNurseDetails(Nurse item)
{
    if (item != null)
        Console.WriteLine($"\nStaffID  : {item.StaffId},       StaffName : {item.StaffName},       City : {item.City},       Education : {item.Education},       NoOfRoomsVisitedPerDay  : {item.NoofRoomsVisitedPerDay},      Experience : {item.Experience}");

}

static void ShowDriverDetails(Driver item)
{
    if (item != null)
        Console.WriteLine($"\nStaffID  : {item.StaffId},       StaffName : {item.StaffName},       City : {item.City},       Education : {item.Education},       NoOFTripsPerDay : {item.NoOfTripsPerDay},      VehicleType : {item.VehicleType}");

}


static void DisplaySalaryOfNurse(int ID, IOperations<Nurse, int> ONur)
{
    WordsToDigits wordGenerator = new WordsToDigits();
    if (ONur.Salary(ID) != null)
    {
        var res = ONur.Salary(ID);
        Console.WriteLine("===============================================================================================");
        Console.WriteLine("\t\t\t\tStaff Details");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($"\n Staff Name : {res[0]} \t\t Staff Id : {ID} \t\t StaffType : Nurse");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
        Console.WriteLine(" \t\t\t\t Income Details  ");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Basic Pay : In Digit :  Rs.{res[1]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[1]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Gross Income :In Digit :  Rs.{res[2]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Tax Paid :In Digit :  Rs.{res[3]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
        Console.WriteLine();

        Console.WriteLine(" Net Income : ");
        Console.WriteLine($" In Digit :  Rs.{Convert.ToInt32(res[2]) - Convert.ToInt32(res[3])}");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]) - Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
    }
    else
    {
        Console.WriteLine("Sorry, You have entered Invalid ID");
    }
}

static void DisplaySalaryOfDriver(int ID, IOperations<Driver, int> ODr)
{
    WordsToDigits wordGenerator = new WordsToDigits();
    if (ODr.Salary(ID) != null)
    {
        var res = ODr.Salary(ID);
        Console.WriteLine("===============================================================================================");
        Console.WriteLine("\t\t\t\tStaff Details");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($"\n Staff Name : {res[0]} \t\t Staff Id : {ID} \t\t StaffType : Driver");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
        Console.WriteLine(" \t\t\t\t Income Details  ");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Basic Pay : In Digit :  Rs.{res[1]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[1]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Gross Income :In Digit :  Rs.{res[2]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]))}");
        Console.WriteLine();
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
        Console.WriteLine($" Tax Paid :In Digit :  Rs.{res[3]} ");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
        Console.WriteLine();

        Console.WriteLine(" Net Income : ");
        Console.WriteLine($" In Digit :  Rs.{Convert.ToInt32(res[2]) - Convert.ToInt32(res[3])}");

        Console.WriteLine($" In Words : {wordGenerator.GetStringforDigit(Convert.ToInt32(res[2]) - Convert.ToInt32(res[3]))}");
        Console.WriteLine();

        Console.WriteLine("===============================================================================================");
    }
    else
    {
        Console.WriteLine("Sorry, You have entered Invalid ID");
    }
}

static void UpdateDriver(Driver driver, List<string> StaffDataList, IOperations<Driver, int> ODr)
{
    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("VehicleTYpe   NoofTripsPerDay");

    driver = new Driver()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        VehicleType = Console.ReadLine(),
        NoOfTripsPerDay = Convert.ToInt32(Console.ReadLine()),

    };
    Console.WriteLine("Now, Enter the StaffId to Update the Record");
    int StaffIdToUpdateDetails = Convert.ToInt32(Console.ReadLine());
    var res = ODr.Update(StaffIdToUpdateDetails, driver);
    if (res != null)
    {
        Console.WriteLine("The Updated Staff Details are : ");
        ShowDriverDetails(res);
    }
}

static void UpdateNurse(Nurse nurse, List<string> StaffDataList, IOperations<Nurse, int> ONur)
{
    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("Experience   NoOfRoomsVisitedPerDay");

    nurse = new Nurse()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        Experience = Convert.ToInt32(Console.ReadLine()),
        NoofRoomsVisitedPerDay = Convert.ToInt32(Console.ReadLine()),

    };

    Console.WriteLine("Now, Enter the StaffId to Update the Record");
    int StaffIdToUpdateDetails = Convert.ToInt32(Console.ReadLine());
    var res = ONur.Update(StaffIdToUpdateDetails, nurse);
    if (res != null)
    {
        Console.WriteLine("The Updated Staff Details are : ");
        ShowNurseDetails(res);
    }
}

static void UpdateDoctor(Doctor doctor, List<string> StaffDataList, IOperations<Doctor, int> Odoc)
{

    Console.WriteLine("\nEnter few more details : \n");
    Console.WriteLine("Specialization   Fees   MaxPatientsPerDay");

    doctor = new Doctor()
    {

        StaffId = Convert.ToInt32(StaffDataList[0]),
        StaffName = StaffDataList[1],
        City = StaffDataList[2],
        Education = StaffDataList[3],
        BasicPay = Convert.ToInt32(StaffDataList[4]),
        Specilization = Console.ReadLine(),
        Fees = Convert.ToInt32(Console.ReadLine()),
        MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine()),
    };

    Console.WriteLine("Now, Enter the StaffId to Update the Record");
    int StaffIdToUpdateDetails = Convert.ToInt32(Console.ReadLine());
    var res = Odoc.Update(StaffIdToUpdateDetails, doctor);
    if (res != null)
    {
        Console.WriteLine("The Updated Staff Details are : ");
        ShowDoctorDetails(res);
    }

}

