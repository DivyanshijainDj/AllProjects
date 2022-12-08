// See https://aka.ms/new-console-template for more information

using Csv_Assignment;
Console.WriteLine("Creating CSV file !!");


FileOperation operation = new FileOperation(@"C:\Coditas\random.csv");

List<Staff> list = new List<Staff>() {
                  new Staff() { StaffId = 1, StaffName = "Mukund", StaffCategory = "Doctor", Email = "mukund@gmail.com",
                       Education = "MBBS", ContactNo = 8373383888 },
                    new Staff() { StaffId = 2, StaffName = "Smita", StaffCategory = "Nurse", Email = "smita@gmail.com",
                        Education = "Bfarm", ContactNo = 8473383888 },
                     new Staff()
                     {
                         StaffId = 3,
                         StaffName = "Ram",
                         StaffCategory = "Technician",
                         Email = "ram@gmail.com",
                         Education = "ITI",
                         ContactNo = 8573383888
                     },
                      new Staff()
                      {
                          StaffId = 4,
                          StaffName = "Hari",
                          StaffCategory = "Doctor",
                          Email = "hari@gmail.com",
                          Education = "MBBS",
                          ContactNo = 8673383888
                      },
                       new Staff()
                       {
                           StaffId = 5,
                           StaffName = "Diva",
                           StaffCategory = "Nurse",
                           Email = "diva@gmail.com",
                           Education = "Bfarm",
                           ContactNo = 8773383888
                       },
                        new Staff()
                        {
                            StaffId = 6,
                            StaffName = "hydra",
                            StaffCategory = "Doctor",
                            Email = "mukund@gmail.com",
                            Education = "MBBS",
                            ContactNo = 8373383888
                        },
                         new Staff()
                         {
                             StaffId = 7,
                             StaffName = "Santosh",
                             StaffCategory = "Technician",
                             Email = "santosh@gmail.com",
                             Education = "ITI",
                             ContactNo = 8873383888
                         },
                          new Staff()
                          {
                              StaffId = 8,
                              StaffName = "Mukund",
                              StaffCategory = "Doctor",
                              Email = "mukund@gmail.com",
                              Education = "MBBS",
                              ContactNo = 8373383888
                          },
                           new Staff()
                           {
                               StaffId = 9,
                               StaffName = "Nayan",
                               StaffCategory = "Nurse",
                               Email = "nayan@gmail.com",
                               Education = "MBBS",
                               ContactNo = 8373383888
                           },
                            new Staff()
                            {
                                StaffId = 10,
                                StaffName = "Rutuja",
                                StaffCategory = "Technician",
                                Email = "rutuja@gmail.com",
                                Education = "ITI",
                                ContactNo = 8373383888
                            },
                             new Staff()
                             {
                                 StaffId = 11,
                                 StaffName = "Mansi",
                                 StaffCategory = "Doctor",
                                 Email = "mansi@gmail.com",
                                 Education = "MBBS",
                                 ContactNo = 8373383888
                             },
                              new Staff()
                              {
                                  StaffId = 12,
                                  StaffName = "Mukund",
                                  StaffCategory = "Doctor",
                                  Email = "mukund@gmail.com",
                                  Education = "MBBS",
                                  ContactNo = 8373383888
                              },
                               new Staff()
                               {
                                   StaffId = 13,
                                   StaffName = "Priyanka",
                                   StaffCategory = "Technician",
                                   Email = "priyanka@gmail.com",
                                   Education = "ITI",
                                   ContactNo = 8373383888
                               },
                                new Staff()
                                {
                                    StaffId = 14,
                                    StaffName = "Rishika",
                                    StaffCategory = "Doctor",
                                    Email = "rishika@gmail.com",
                                    Education = "MBBS",
                                    ContactNo = 8373383888
                                },

                                  new Staff()
                                  {
                                      StaffId = 15,
                                      StaffName = "Divyanshi",
                                      StaffCategory = "Nurse",
                                      Email = "divyanshi@gmail.com",
                                      Education = "MBBS",
                                      ContactNo = 8373383888
                                  },
                                   new Staff()
                                   {
                                       StaffId = 16,
                                       StaffName = "Radha",
                                       StaffCategory = "Technician",
                                       Email = "radha@gmail.com",
                                       Education = "ITI",
                                       ContactNo = 8373383888
                                   },
                                    new Staff()
                                    {
                                        StaffId = 17,
                                        StaffName = "Baal",
                                        StaffCategory = "Doctor",
                                        Email = "baal@gmail.com",
                                        Education = "MBBS",
                                        ContactNo = 8373383888
                                    },
                                     new Staff()
                                     {
                                         StaffId = 18,
                                         StaffName = "Angrybird",
                                         StaffCategory = "Nurse",
                                         Email = "angrybird@gmail.com",
                                         Education = "MBBS",
                                         ContactNo = 8373383888
                                     },
                                      new Staff()
                                      {
                                          StaffId = 19,
                                          StaffName = "Sam",
                                          StaffCategory = "Technician",
                                          Email = "sam@gmail.com",
                                          Education = "ITI",
                                          ContactNo = 8373383888
                                      },
                                       new Staff()
                                       {
                                           StaffId = 20,
                                           StaffName = "AntMan",
                                           StaffCategory = "Doctor",
                                           Email = "antman@gmail.com",
                                           Education = "MBBS",
                                           ContactNo = 8373383888
                                       },
                                        new Staff()
                                        {
                                            StaffId = 21,
                                            StaffName = "Loki",
                                            StaffCategory = "Nurse",
                                            Email = "loki@gmail.com",
                                            Education = "MBBS",
                                            ContactNo = 8373383888
                                        },
                                         new Staff()
                                         {
                                             StaffId = 22,
                                             StaffName = "Thor",
                                             StaffCategory = "Technician",
                                             Email = "thor@gmail.com",
                                             Education = "ITI",
                                             ContactNo = 8373383888
                                         },
                                          new Staff()
                                          {
                                              StaffId = 23,
                                              StaffName = "Ironman",
                                              StaffCategory = "Doctor",
                                              Email = "ironman@gmail.com",
                                              Education = "MBBS",
                                              ContactNo = 8373383888
                                          },
                                           new Staff()
                                           {
                                               StaffId = 24,
                                               StaffName = "Natasha",
                                               StaffCategory = "Nurse",
                                               Email = "natasha@gmail.com",
                                               Education = "MBBS",
                                               ContactNo = 8373383888
                                           }, new Staff()
                                           {
                                               StaffId = 25,
                                               StaffName = "Hulk",
                                               StaffCategory = "Technician",
                                               Email = "hulk@gmail.com",
                                               Education = "ITI",
                                               ContactNo = 8373383888
                                           },
                                            new Staff()
                                            {
                                                StaffId = 26,
                                                StaffName = "Odin",
                                                StaffCategory = "Doctor",
                                                Email = "odin@gmail.com",
                                                Education = "MBBS",
                                                ContactNo = 8373383888
                                            },
                                             new Staff()
                                             {
                                                 StaffId = 27,
                                                 StaffName = "Anjani",
                                                 StaffCategory = "Nurse",
                                                 Email = "anjali@gmail.com",
                                                 Education = "MBBS",
                                                 ContactNo = 8373383888
                                             },
                                              new Staff()
                                              {
                                                  StaffId = 28,
                                                  StaffName = "Mahesh",
                                                  StaffCategory = "Technician",
                                                  Email = "mahesh@gmail.com",
                                                  Education = "ITI",
                                                  ContactNo = 8373383888
                                              },
                                               new Staff()
                                               {
                                                   StaffId = 29,
                                                   StaffName = "Bodybuilder",
                                                   StaffCategory = "Doctor",
                                                   Email = "bodybuilder@gmail.com",
                                                   Education = "MBBS",
                                                   ContactNo = 8373383888
                                               },
                                                new Staff()
                                                {
                                                    StaffId = 30,
                                                    StaffName = "Sham",
                                                    StaffCategory = "Nurse",
                                                    Email = "sham@gmail.com",
                                                    Education = "MBBS",
                                                    ContactNo = 8373383888
                                                },
                                                 new Staff()
                                                 {
                                                     StaffId = 31,
                                                     StaffName = "Hardik",
                                                     StaffCategory = "Technician",
                                                     Email = "hardik@gmail.com",
                                                     Education = "ITI",
                                                     ContactNo = 8373383888
                                                 },
                                                  new Staff()
                                                  {
                                                      StaffId = 32,
                                                      StaffName = "GTR",
                                                      StaffCategory = "Doctor",
                                                      Email = "gtr@gmail.com",
                                                      Education = "MBBS",
                                                      ContactNo = 8373383888
                                                  },
                                                   new Staff()
                                                   {
                                                       StaffId = 33,
                                                       StaffName = "Wagh",
                                                       StaffCategory = "Nurse",
                                                       Email = "wagh@gmail.com",
                                                       Education = "MBBS",
                                                       ContactNo = 8373383888
                                                   },
                                                    new Staff()
                                                    {
                                                        StaffId = 34,
                                                        StaffName = "Navale",
                                                        StaffCategory = "Technician",
                                                        Email = "navale@gmail.com",
                                                        Education = "ITI",
                                                        ContactNo = 8373383888
                                                    },
                                                     new Staff()
                                                     {
                                                         StaffId = 35,
                                                         StaffName = "Hari",
                                                         StaffCategory = "Doctor",
                                                         Email = "hari@gmail.com",
                                                         Education = "MBBS",
                                                         ContactNo = 8373383888
                                                     },
                                                      new Staff()
                                                      {
                                                          StaffId = 36,
                                                          StaffName = "Soham",
                                                          StaffCategory = "Nurse",
                                                          Email = "soham@gmail.com",
                                                          Education = "MBBS",
                                                          ContactNo = 8373383888
                                                      },
                                                       new Staff()
                                                       {
                                                           StaffId = 37,
                                                           StaffName = "Rutwik",
                                                           StaffCategory = "Technician",
                                                           Email = "rutwik@gmail.com",
                                                           Education = "ITI",
                                                           ContactNo = 8373383888
                                                       },
                                                        new Staff()
                                                        {
                                                            StaffId = 38,
                                                            StaffName = "Superman",
                                                            StaffCategory = "Doctor",
                                                            Email = "superman@gmail.com",
                                                            Education = "MBBS",
                                                            ContactNo = 8373383888
                                                        },
                                                         new Staff()
                                                         {
                                                             StaffId = 39,
                                                             StaffName = "Batman",
                                                             StaffCategory = "Nurse",
                                                             Email = "batman@gmail.com",
                                                             Education = "MBBS",
                                                             ContactNo = 8373383888
                                                         },
                                                          new Staff()
                                                          {
                                                              StaffId = 40,
                                                              StaffName = "Villian",
                                                              StaffCategory = "Technician",
                                                              Email = "villian@gmail.com",
                                                              Education = "ITI",
                                                              ContactNo = 8373383888
                                                          },
                                                           new Staff()
                                                           {
                                                               StaffId = 41,
                                                               StaffName = "Sneha",
                                                               StaffCategory = "Doctor",
                                                               Email = "sneha@gmail.com",
                                                               Education = "MBBS",
                                                               ContactNo = 8373383888
                                                           },
                                                            new Staff()
                                                            {
                                                                StaffId = 42,
                                                                StaffName = "Ayush",
                                                                StaffCategory = "Nurse",
                                                                Email = "ayush@gmail.com",
                                                                Education = "MBBS",
                                                                ContactNo = 8373383888
                                                            },
                                                             new Staff()
                                                             {
                                                                 StaffId = 43,
                                                                 StaffName = "Mukund",
                                                                 StaffCategory = "Technician",
                                                                 Email = "mukund@gmail.com",
                                                                 Education = "ITI",
                                                                 ContactNo = 8373383888
                                                             },
                                                              new Staff()
                                                              {
                                                                  StaffId = 44,
                                                                  StaffName = "Ketan",
                                                                  StaffCategory = "Doctor",
                                                                  Email = "ketan@gmail.com",
                                                                  Education = "MBBS",
                                                                  ContactNo = 8373383888
                                                              },
                                                               new Staff()
                                                               {
                                                                   StaffId = 45,
                                                                   StaffName = "Samrudhhi",
                                                                   StaffCategory = "Nurse",
                                                                   Email = "samrudhhi@gmail.com",
                                                                   Education = "MBBS",
                                                                   ContactNo = 8373383888
                                                               },
                                                                new Staff()
                                                                {
                                                                    StaffId = 46,
                                                                    StaffName = "Vaishnavi",
                                                                    StaffCategory = "Technician",
                                                                    Email = "vaishnavi@gmail.com",
                                                                    Education = "ITI",
                                                                    ContactNo = 8373383888
                                                                },
                                                                 new Staff()
                                                                 {
                                                                     StaffId = 47,
                                                                     StaffName = "Samadhan",
                                                                     StaffCategory = "Doctor",
                                                                     Email = "samadhan@gmail.com",
                                                                     Education = "MBBS",
                                                                     ContactNo = 8373383888
                                                                 },
                                                                  new Staff()
                                                                  {
                                                                      StaffId = 48,
                                                                      StaffName = "Gorakh",
                                                                      StaffCategory = "Nurse",
                                                                      Email = "gorakh@gmail.com",
                                                                      Education = "MBBS",
                                                                      ContactNo = 8373383888
                                                                  },
                                                                   new Staff()
                                                                   {
                                                                       StaffId = 49,
                                                                       StaffName = "Stuti",
                                                                       StaffCategory = "Technician",
                                                                       Email = "stuti@gmail.com",
                                                                       Education = "ITI",
                                                                       ContactNo = 8373383888
                                                                   },
                                                                    new Staff()
                                                                    {
                                                                        StaffId = 50,
                                                                        StaffName = "Rashmika",
                                                                        StaffCategory = "Doctor",
                                                                        Email = "rashmika@gmail.com",
                                                                        Education = "MBBS",
                                                                        ContactNo = 8373383888
                                                                    }
                                                                 };
try
{

    operation.csvgenerate();
    operation.CsvWrite(list);

    char ch = 'y';
    do
    {
        Console.WriteLine("\nOperations : \n");
        Console.WriteLine("1.Read StaffData by StaffId");
        Console.WriteLine("2.Read StaffData by StaffCategory");
        Console.WriteLine("\nEnter your choice...");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {

                    Console.WriteLine("Enter the StaffId to Get Record...");
                    int StaffId = Convert.ToInt32(Console.ReadLine());
                    operation.SearchByID(StaffId);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Enter the StaffCategory to Get Records...");
                    string StaffCategory = Console.ReadLine();
                    operation.CategorySearch(StaffCategory);

                    break;
                }

            default:
                {
                    Console.WriteLine("Invalid Choice...!!");
                    break;
                }
        }
        Console.WriteLine("\nWanna perform any other operation..?");
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
