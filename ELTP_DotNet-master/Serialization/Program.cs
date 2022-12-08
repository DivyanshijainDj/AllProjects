﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using Serialization;

Console.WriteLine("Simple Class");
StaffLogic logic = new StaffLogic();
Staff staff = new Staff();
string? continueExecution = "y";
do
{

    Console.WriteLine("Enter your choice to perform operation");
    Console.WriteLine("1. Register new staff.");
    Console.WriteLine("2. Show List of staff.");
    Console.WriteLine("3. Update the staff record.");
    Console.WriteLine("4. Delete staff record.");
    Console.WriteLine();


    
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            {
                Console.WriteLine("Enter Details of new record \nId" +
                    "\nName\nEmail\nDepartment name\nGender\nDate of Birth\nStaff Category\nEducation\nContact Number");
                staff = new Staff()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    DeptName = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                    DateOfBirth = DateTime.Parse(Console.ReadLine()),
                    StaffCategory = Console.ReadLine(),
                    Education = Console.ReadLine(),
                    ContatNo = Convert.ToInt32(Console.ReadLine())
                };

                Stream fs = new FileStream(@"c:\Coditas\Files\" + $"{staff.StaffId}.json ", FileMode.CreateNew);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                //binaryFormatter.Serialize(fs, emp);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                JsonSerializer.Serialize(fs, staff);
                Console.WriteLine("The Object is Serialized");
                fs.Close(); // CLose the File
                fs.Dispose();




                break;
            }
        case 2:
            {


                Console.WriteLine("Enter Id to des");
                int ID = Convert.ToInt32(Console.ReadLine());

                Stream fs = new FileStream(@"c:\Coditas\Files\" + ID +".json", FileMode.Open);
                        #pragma warning disable SYSLIB0011 // Type or member is obsolete
                    //binaryFormatter.Serialize(fs, emp);
                        #pragma warning restore SYSLIB0011 // Type or member is obsolete
                    Staff st = JsonSerializer.Deserialize<Staff>(fs);
                    Console.WriteLine("The Object is De-Serialized");
                    Console.WriteLine($"{st.StaffName} {st.StaffId} {st.DeptName} {st.DateOfBirth}");
                    fs.Close(); // CLose the File
                    fs.Dispose();
                    
                    //deserialzie
                
                break;
            }
        case 3:

            Console.WriteLine("Enter Id to be Updated");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Details of new record \nId" +
                "\nName\nEmail\nDepartment name\nGender\nDate of Birth\nStaff Category\nEducation\nContact Number");
            staff = new Staff()
            {
                StaffId = Convert.ToInt32(Console.ReadLine()),
                StaffName = Console.ReadLine(),
                Email = Console.ReadLine(),
                DeptName = Console.ReadLine(),
                Gender = Console.ReadLine(),
                DateOfBirth = DateTime.Parse(Console.ReadLine()),
                StaffCategory = Console.ReadLine(),
                Education = Console.ReadLine(),
                ContatNo = Convert.ToInt32(Console.ReadLine())

            };
            var staffs = logic.UpdateStaffInfo(id, staff);
            Console.WriteLine("Updated information ");
            foreach (var s in staffs)
            {
                Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}");
            }
            break;
        case 4:
            Console.WriteLine("Enter id to be deleted");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());
            var staf = logic.DeleteStaff(IdToDelete);
            Console.WriteLine("Information after delete: ");
            foreach (var s in staf)
            {
                Console.WriteLine($"{s.StaffId}     {s.StaffName}       {s.Email}    {s.DeptName}     {s.Gender}      {s.DateOfBirth}     {s.StaffCategory}       {s.Education}       {s.ContatNo}");
            }
            break;
    }
    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
} while (continueExecution == "y" || continueExecution == "Y");
Console.ReadLine();
