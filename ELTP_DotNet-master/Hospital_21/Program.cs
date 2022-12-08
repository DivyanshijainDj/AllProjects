using Hospital_21.Logic;
using Hospital_21.Models;
using Hospital_21.Logic;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information

char Choice;
decimal DocCount = 1, NurCount = 500, TechCount = 1000;

Doctor doc = new Doctor();
DoctorLogic doctorLogic = new DoctorLogic();
Nurse nurse = new Nurse();


NurseLogic nurselogic = new NurseLogic();
SearchGateway searchGateway = new SearchGateway();
Technician technician = new Technician();
TechnicainLogicAbs technicainLogic = new TechnicainLogicAbs();

do

{
    List<String> StaffData = new List<string>();
    Console.WriteLine("\n Operations : \n");
    Console.WriteLine("1.Register");
    Console.WriteLine("2.Show All");
    Console.WriteLine("3.Doctors Based on Specialization");
    Console.WriteLine("4.Delete using ID");
    Console.WriteLine("5.Update using ID");
    Console.WriteLine("6.Calculate the income");
    Console.WriteLine("7.Search Staff by StaffName");

    Console.WriteLine();
    int OperationChoice = Convert.ToInt32(Console.ReadLine());
    switch (OperationChoice)
    {


        case 1:
            {
                Console.WriteLine("<============================Enter details===============================>\n");
                Console.WriteLine();
                Console.WriteLine("StaffName   Email   ContactNo   Education   ShiftStartTime   ShiftEndTime   StaffCategory");
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                StaffData.Add(Console.ReadLine());
                String staffCat = Console.ReadLine();
                

                if (staffCat == "doctor")
                {
                    RegisterDoctor(doc, StaffData, doctorLogic, ref DocCount);

                }
                else if (staffCat == "nurse")
                {
                    RegisterNurse(nurse, StaffData, nurselogic, ref NurCount);

                }
                else if (staffCat == "technician")
                {
                    RegisterTechnician(technician, StaffData, technicainLogic, ref TechCount);
                }
                else
                {
                    Console.WriteLine("Invalid StaffCategory");
                }
                break;
            }

        case 2:
            {
                PrintMethod(doctorLogic, technicainLogic, nurselogic);
                break;
            }
        case 3:
            {
                Console.WriteLine("Enter Specialization ");
                String specialization = Console.ReadLine();
                var v = doctorLogic.GetRecordBasedOnSpecialization(specialization);
                foreach (var itr in v)
                {
                    Console.WriteLine($"\nStaffId :  {itr.StaffId},    StaffName : {itr.StaffName},   ContactNo : {itr.ContactNo},   MaxPatientsPerDay : {itr.MaxPatientsPerDay},    Fees : {itr.Fees},   Email : {itr.Email}");

                }
                break;
            }
        case 4:
            {

                DeleteStaffUsingID(doctorLogic, nurselogic, technicainLogic);
                break;
            }
        case 5:
            {
                Console.WriteLine("StaffId to Update the Record");
                decimal id = Convert.ToDecimal(Console.ReadLine());
                while (id <= 0)
                {

                    Console.WriteLine("Invalid");
                    id = Convert.ToDecimal(Console.ReadLine());
                }
                UpdateStaffRecord(id, doc, doctorLogic, nurse, nurselogic, technician, technicainLogic);

                break;
            }

        case 6:
            {
                Console.WriteLine("Enter the StaffId to Calculate the Income");
                decimal id = Convert.ToDecimal(Console.ReadLine());
                while (id <= 0)
                {

                    Console.WriteLine("Invalid ID..Try Again");
                    id = Convert.ToDecimal(Console.ReadLine());
                }
                StaffLogicAbstract staffLogicAbstract;
                Accounts accounts = new Accounts();
                if (id < 500)
                {
                    staffLogicAbstract = doctorLogic;
                }
                else if (id < 1000)
                {
                    staffLogicAbstract = nurselogic;
                }
                else
                {
                    staffLogicAbstract = technicainLogic;
                }
                Console.WriteLine($"The Staff of ID {id} have income = {accounts.GetStaffIncome(id, staffLogicAbstract)}");

                break;
            }
        case 7:
            {
                Console.WriteLine("StaffName to Search the Record");
                var v = searchGateway.SearchMethod(Console.ReadLine());
                foreach (var itr in v)
                {
                    Console.WriteLine($"\nStaffId :  {itr.StaffId},    StaffName : {itr.StaffName},   ContactNo : {itr.ContactNo},    Email : {itr.Email}    Education : {itr.Education},    ShiftStartTime : {itr.ShiftStartTime},   ShiftEndTime : {itr.ShiftEndTime}");

                }
                break;
            }
    }
    Console.WriteLine("Wanna perform any other operation y/n");
    Choice = Convert.ToChar(Console.ReadLine());
    Console.Clear();
} while (Choice == 'y' || Choice == 'Y');



static void RegisterDoctor(Doctor doc, List<String> StaffDataList, DoctorLogic doctorLogic, ref decimal docCount)
{

    Console.WriteLine("\n<====================Enter specific details :=======================> \n");
    Console.WriteLine("Specialization   Fees   MaxPatientsPerDay   Basic Pay");

    doc = new Doctor()
    {
        StaffId = Convert.ToInt32(docCount),
        StaffName = StaffDataList[0],
        Email = StaffDataList[1],
        ContactNo = StaffDataList[2],
        Education = StaffDataList[3],
        ShiftStartTime = StaffDataList[4],
        ShiftEndTime = StaffDataList[5],
        Specialization = Console.ReadLine(),
        Fees = Convert.ToInt32(Console.ReadLine()),
        MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine()),

        BasicPay = Convert.ToInt32(Console.ReadLine())

    };
    Console.WriteLine(doctorLogic.DoctorRegisteration(doc));
    docCount++;


}


static void RegisterNurse(Nurse nurse, List<String> StaffDataList, NurseLogic nurseLogic, ref decimal nurCount)
{


    Console.WriteLine("\n<====================Enter specific details :=======================> \n");
    Console.WriteLine("Specialization   NoOfRoomsVisitedPerDay  ServiceType   Basic Pay");
    nurse = new Nurse()
    {
        StaffId = Convert.ToInt32(nurCount),
        StaffName = StaffDataList[0],
        Email = StaffDataList[1],
        ContactNo = StaffDataList[2],
        Education = StaffDataList[3],
        ShiftStartTime = StaffDataList[4],
        ShiftEndTime = StaffDataList[5],
        Specialization = Console.ReadLine(),
        BasicPay = Convert.ToInt32(Console.ReadLine())

    };
    Console.WriteLine(nurseLogic.NurseRegisteration(nurse));
    nurCount++;
}



static void RegisterTechnician(Technician technician, List<String> StaffDataList, TechnicainLogicAbs technicainLogic, ref decimal techCount)
{


    Console.WriteLine("\n<====================Enter specific details :=======================> \n");
    Console.WriteLine("Specialization  NoOfMachineCheckedPerDay   Basic Pay");

    technician = new Technician()
    {
        StaffId = Convert.ToInt32(techCount),
        StaffName = StaffDataList[0],
        Email = StaffDataList[1],
        ContactNo = StaffDataList[2],
        Education = StaffDataList[3],
        ShiftStartTime = StaffDataList[4],
        ShiftEndTime = StaffDataList[5],
        Specialization = Console.ReadLine(),        
        BasicPay = Convert.ToInt32(Console.ReadLine())

    };

    Console.WriteLine(technicainLogic.TechnicianRegisteration(technician));
    techCount++;
}
static void PrintMethod(DoctorLogic doctorLogic, TechnicainLogicAbs technicainLogic, NurseLogic nurselogic)
{
    Console.WriteLine("\n1.Doctors Details");
    Console.WriteLine("2.Nurse Details");
    Console.WriteLine("3.Technician Details");
    Console.WriteLine("Enter you Choice");
    int ChoiceforViewingStaffDetails = Convert.ToInt32(Console.ReadLine());
    switch (ChoiceforViewingStaffDetails)
    {
        case 1:
            {
                var v = doctorLogic.GetAllDoctors();

                foreach (var itr in v)
                {
                    Console.WriteLine($"\nStaffId :  {itr.Value.StaffId},    StaffName : {itr.Value.StaffName},   ContactNo : {itr.Value.ContactNo},   MaxPatientsPerDay : {itr.Value.MaxPatientsPerDay},    BasicPay : {itr.Value.BasicPay}   Fees : {itr.Value.Fees},   Email : {itr.Value.Email}");
                }
                break;
            }
        case 2:
            {
                var v = nurselogic.GetAllNurse();

                foreach (var itr in v)
                {
                    Console.WriteLine($"\nStaffId :  {itr.Value.StaffId},    StaffName : {itr.Value.StaffName},   ContactNo : {itr.Value.ContactNo},   Email : {itr.Value.Email}");
                }
                break;

            }
        case 3:
            {

                var v = technicainLogic.GetAllTechnician();

                foreach (var itr in v)
                {
                    Console.WriteLine($"\nStaffId :  {itr.Value.StaffId},    StaffName : {itr.Value.StaffName},   ContactNo : {itr.Value.ContactNo},       Email : {itr.Value.Email}");
                }
                break;
            }
        default:
            Console.WriteLine("Invalid Choice ");
            break;



    }
}
static void DeleteStaffUsingID(DoctorLogic doctorLogic, NurseLogic nurseLogic, TechnicainLogicAbs technicainLogic)
{



    Console.WriteLine("\n<=========================StaffId to Delete ===================>");
    decimal id = Convert.ToDecimal(Console.ReadLine());
    while (id <= 0)
    {

        Console.WriteLine("Invalid Key..Try Again");
        id = Convert.ToDecimal(Console.ReadLine());
    }

    if (id < 500)
    {
        doctorLogic.DeleteRecord(id);

    }
    else if (id < 1000)
    {
        nurseLogic.DeleteRecord(id);
    }
    else
    {
        technicainLogic.DeleteRecord(id);
    }

}

static void UpdateStaffRecord(decimal id, Doctor doc, DoctorLogic doctorLogic, Nurse nurse, NurseLogic nurselogic, Technician technician, TechnicainLogicAbs technicainLogic)
{
    List<String> StaffDataList = new List<string>();
    Console.WriteLine("<======================== Details to Update===========================>\n");
    Console.WriteLine("StaffName   Email   ContactNo   Education   ShiftStartTime   ShiftEndTime   StaffCategory");

    StaffDataList.Add(Console.ReadLine());
    StaffDataList.Add(Console.ReadLine());
    StaffDataList.Add(Console.ReadLine());
    StaffDataList.Add(Console.ReadLine());
    StaffDataList.Add(Console.ReadLine());
    StaffDataList.Add(Console.ReadLine());
    String staffCat = Console.ReadLine();
    staffCat = staffCat.ToLower();


    if (staffCat == "doctor")
    {
        Console.WriteLine("\n<====================Enter specific details :=======================> \n");
        Console.WriteLine("Specialization   Fees   MaxPatientsPerDay   BasicPay");

        doc = new Doctor()
        {
            StaffId = Convert.ToInt32(id),
            StaffName = StaffDataList[0],
            Email = StaffDataList[1],
            ContactNo = StaffDataList[2],
            Education = StaffDataList[3],
            ShiftStartTime = StaffDataList[4],
            ShiftEndTime = StaffDataList[5],
            Specialization = Console.ReadLine(),
            Fees = Convert.ToInt32(Console.ReadLine()),
            MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine()),
            BasicPay = Convert.ToInt32(Console.ReadLine())


        };
        var v = doctorLogic.UpdateDoctorRecord(id, doc);

    }
    else if (staffCat == "nurse")
    {

        Console.WriteLine("\n<====================Enter specific details :=======================> \n");
        Console.WriteLine("Specialization   NoOfRoomsVisitedPerDay  ServiceType   BasicPay");
        nurse = new Nurse()
        {
            StaffId = Convert.ToInt32(id),
            StaffName = StaffDataList[0],
            Email = StaffDataList[1],
            ContactNo = StaffDataList[2],
            Education = StaffDataList[3],
            ShiftStartTime = StaffDataList[4],
            ShiftEndTime = StaffDataList[5],
            Specialization = Console.ReadLine(),            
            BasicPay = Convert.ToInt32(Console.ReadLine())

        };
        var v = nurselogic.UpdateNurseRecord(id, nurse);

    }
    else if (staffCat == "technician")
    {
        Console.WriteLine("\n<====================Enter specific details :=======================> \n");
        Console.WriteLine("Specialization  NoOfMachineCheckedPerDay   BasicPay");
        technician = new Technician()
        {
            StaffId = Convert.ToInt32(id),
            StaffName = StaffDataList[0],
            Email = StaffDataList[1],
            ContactNo = StaffDataList[2],
            Education = StaffDataList[3],
            ShiftStartTime = StaffDataList[4],
            ShiftEndTime = StaffDataList[5],
            Specialization = Console.ReadLine(),
            BasicPay = Convert.ToInt32(Console.ReadLine())


        };

        var v = technicainLogic.UpdateTechnicianRecord(id, technician);
    }
    else
    {
        Console.WriteLine("Invalid StaffCategory....Please try Again!");
    }

}

Console.ReadLine();
