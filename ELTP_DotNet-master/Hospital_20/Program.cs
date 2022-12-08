using Hospital_20;

Console.WriteLine();
Console.WriteLine("<=========================CURD Using Dictionary============================>");
Console.WriteLine();

Doctor doctor = new Doctor();
DoctorLogic doctorLogic = new DoctorLogic();
Nurse nurse = new Nurse();
NurseLogic nurseLogic = new NurseLogic();
Technician technician = new Technician();
TechnicanLogic technicanLogic = new TechnicanLogic();


string? continueExecution = "y";
do
    
{

    Console.WriteLine("Please choose Category");
    Console.WriteLine("1. Doctor.");
    Console.WriteLine("2. Nurse");
    Console.WriteLine("3. Technician");
    Console.WriteLine();
    
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {

        case 1:

            Console.WriteLine("<===========================Doctors Details==========================>");
            string? continueExecutionDoctor = "y";
            do
            {
                Console.WriteLine("Enter your choice to perform operation");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Show records");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Search by speacialization");
                Console.WriteLine("6. Income");
                Console.WriteLine();
                Console.WriteLine("<======================================================================>");
                Console.WriteLine();
                int choiceDoctor = Convert.ToInt32(Console.ReadLine());
                switch (choiceDoctor)
                {
                    case 1:
                        String str = "Doctor:";
                        Console.WriteLine("Unique Key for Doctor: ");
                        String key = str + Console.ReadLine();
                        Console.WriteLine("Please Enter Details \nId" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        doctor = new Doctor()
                        {
                            
                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };


                        var stafs = doctorLogic.RegisterNewDoctor(key, doctor);
                        foreach (var s in stafs)
                        {
                            Console.WriteLine($"{s.Key}");
                        }

                        Console.WriteLine("<======================After Insertion===============================");
                        foreach (var s in stafs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        
                        
                        break;

                        //Console.Clear();

                    case 2:
                        var stf = doctorLogic.GetAllDoctors();

                        foreach (var s in stf)
                        {
                            Console.WriteLine($"{s.Key}");
                            
                        }
                        foreach (var s in stf.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}          {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        
                        break;
                        


                    case 3:
                        Console.WriteLine("Enter Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Details of new record \nId" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        doctor = new Doctor()
                        {
                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };

            
                        var staffs = doctorLogic.UpdateDoctorInfo(id, doctor);
                        Console.WriteLine("<=======================After Updation=======================> ");
                        foreach (var s in staffs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        break;
                        //Console.Clear();

                    case 4:
                        Console.WriteLine("Enter unique ID");
                        String IdToDelete = Console.ReadLine();
                        var staf = doctorLogic.DeleteDoctor(IdToDelete);
                        Console.WriteLine("Data deleted sucessfully");

                        Console.WriteLine("<=======================After Deletion=======================> ");
                        foreach (var s in staf.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}           {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;

                        //Console.Clear();

                    case 5:
                        Console.WriteLine("Enter Specialization to search ");
                        string? spec = Console.ReadLine();
                        var stfVal = doctorLogic.GetAllDoctors();

                        foreach (var s in stfVal.Values)
                        {
                            if (s.Specialization == spec)
                                Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}           {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;

                        //Console.Clear();

                   
                    case 6:
                        Console.WriteLine("Enter Id to get income");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        var income = doctorLogic.netIncome(idd);
                        Console.WriteLine($"Income of doctor is: {income}");
                        break;
                    default:

                        break;
                }
                Console.WriteLine("Please enter y or Y to continue");
                continueExecutionDoctor = Console.ReadLine();
                Console.Clear();
            } while (continueExecutionDoctor == "y" || continueExecutionDoctor == "Y");
            break;

        case 2:
            Console.WriteLine("<===========================NURSE Details==========================>");

            string? continueExecutionNurse = "y";
            do
            {
                Console.WriteLine("Enter your choice to perform operation");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Show records");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Search by speacialization");
                Console.WriteLine("6. Income");
                Console.WriteLine();
                Console.WriteLine("<======================================================================>");

                
                int choiceNurse = Convert.ToInt32(Console.ReadLine());
                switch (choiceNurse)
                {
                    case 1:
                        String str = "Nurse:";
                        Console.WriteLine("Unique Key for Nurse");
                        String key = str + Console.ReadLine();
                        Console.WriteLine("Enter Details of new record \nId" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        nurse = new Nurse()
                        {
                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };
                        var stafs = nurseLogic.RegisterNewNurse(key, nurse);
                        foreach (var s in stafs)
                        {
                            Console.WriteLine($"{s.Key}");
                        }

                        Console.WriteLine("<======================After Insertion===============================");

                        foreach (var s in stafs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}         {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }


                        break;

                    case 2:
                        var stf = nurseLogic.GetAllNurses();

                        foreach (var s in stf)
                        {
                            Console.WriteLine($"{s.Key}");
                        }

                        foreach (var s in stf.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}         {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Id to be Updated");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Details of new record \nId" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        nurse = new Nurse()
                        {
                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };
                        var staffs = nurseLogic.UpdateNurseInfo(id, nurse);
                        Console.WriteLine("<=======================After Updation=======================> ");


                        foreach (var s in staffs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}          {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter unique id: ");
                        string IdToDelete = Console.ReadLine();
                        var staf = nurseLogic.DeleteNurse(IdToDelete);
                        Console.WriteLine("<=======================After Deletion=======================> ");
                        foreach (var s in staf.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Specialization to search ");
                        string? spec = Console.ReadLine();
                        var stfVal = nurseLogic.GetAllNurses();

                        foreach (var s in stfVal.Values)
                        {
                            if (s.Specialization == spec)
                                Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;
                   
                    case 6:
                        Console.WriteLine("Enter Id to get income");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        var income = nurseLogic.netIncome(idd);
                        Console.WriteLine($"Income:-{income}");
                        break;
                    default:

                        break;



                }
                Console.WriteLine("Please enter y or Y to continue \nFor Main menu enter any key");
                continueExecutionNurse = Console.ReadLine();
            } while (continueExecutionNurse == "y" || continueExecutionNurse == "Y");

            break;

        case 3:
            Console.WriteLine("<===========================TECHNICIAN Details==========================>");

            string? continueExecutionTechnitionn = "y";
            do
            {
                Console.WriteLine("Enter your choice to perform operation");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Show records");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Search by speacialization");
                Console.WriteLine("6. Income");
                Console.WriteLine();
                Console.WriteLine("<======================================================================>");

                int choiceTechnican = Convert.ToInt32(Console.ReadLine());
                switch (choiceTechnican)
                {
                    case 1:
                        String str = "Technician: ";
                        Console.WriteLine("Unique key for Technician: ");
                        String key = str + Console.ReadLine();
                        Console.WriteLine("Enter Details of new record \nId" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        technician = new Technician()
                        {
                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };
                        technicanLogic.RegisterNewTechnician(key, technician);
                        var stafs = technicanLogic.GetAllTechnicians();
                        foreach (var s in stafs)
                        {
                            Console.WriteLine($"{s.Key}");
                        }

                        Console.WriteLine("<======================After Insertion===============================");

                        foreach (var s in stafs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}            {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }


                        break;

                    case 2:
                        var stfValue = technicanLogic.GetAllTechnicians();
                        foreach (var s in stfValue)
                        {
                            Console.WriteLine($"{s.Key}");
                        }

                        foreach (var s in stfValue.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}         {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Id to be Updated");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("press key which attribute you want to update");
                        Console.WriteLine("Enter Details of new record \n1. Id" +
                                "   Name\nEmail\nDepartment\nGender\nDOB\nEducation\nContact\nShiftStartTime\nShiftEndTime\nBasicPay\nSpecialization\nFees");
                        technician = new Technician()
                        {

                            StaffId = Convert.ToInt32(Console.ReadLine()),
                            StaffName = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            DeptName = Console.ReadLine(),
                            Gender = Console.ReadLine(),
                            DateOfBirth = DateTime.Parse(Console.ReadLine()),
                            Education = Console.ReadLine(),
                            ContatNo = Convert.ToInt32(Console.ReadLine()),
                            ShiftStartTime = Console.ReadLine(),
                            ShiftEndTime = Console.ReadLine(),
                            BasicPay = Convert.ToInt32(Console.ReadLine()),
                            Specialization = Console.ReadLine(),
                            Fees = Convert.ToInt32(Console.ReadLine())

                        };
                        var staffs = technicanLogic.UpdateTechnicianInfo(id, technician);
                        Console.WriteLine("<=======================After Updation=======================> ");

                        foreach (var s in staffs.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}            {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter unique ID");
                        string? IdToDelete = Console.ReadLine();
                        var staf = technicanLogic.DeleteTechnician(IdToDelete);
                        Console.WriteLine("<=====================After Delete===========================> ");
                        foreach (var s in staf.Values)
                        {
                            Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}            {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Specialization to search ");
                        string? spec = Console.ReadLine();
                        var stfVal = technicanLogic.GetAllTechnicians();

                        foreach (var s in stfVal.Values)
                        {
                            if (s.Specialization == spec)
                                Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}            {s.Education}       {s.ContatNo}   {s.ShiftStartTime}   {s.ShiftEndTime}       {s.BasicPay}  {s.Specialization}    {s.Fees}");
                        }

                        break;
                   
                    case 6:
                        Console.WriteLine("Enter Id to get income");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        var income = technicanLogic.netIncome(idd);
                        Console.WriteLine($"Income:-{income}");
                        break;

                }
                Console.WriteLine("Please enter y or Y to continue");
                continueExecutionTechnitionn = Console.ReadLine();
            } while (continueExecutionTechnitionn == "y" || continueExecutionTechnitionn == "Y");

            break;

            

    }
    Console.WriteLine("Continue? Press y");
    continueExecution = Console.ReadLine();
} while (continueExecution == "y" || continueExecution == "Y");
Console.ReadLine();