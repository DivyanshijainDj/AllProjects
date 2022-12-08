using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entity
{
    
        public class Staff
        {


            protected string ValidationOfStringInput(string temp, string type)
            {
                bool flag = true;
                while (flag)
                {
                    foreach (char c in temp)
                    {
                        if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {

                        return temp;
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine($"Invalid {type}, Try Again..");
                        temp = Console.ReadLine();
                    }

                }
                return temp;
            }
            private int _StaffId;
            public int StaffId
            {
                get
                {
                    return _StaffId;
                }
                set
                {

                    _StaffId = value;
                }
            }
            private string _StaffName;
            public string StaffName
            {
                get
                {
                    return _StaffName;
                }
                set
                {
                    _StaffName = value;

                }
            }
            private string _Education;
            public string Education
            {
                get
                {
                    return _Education;
                }
                set
                {
                    _Education = value;
                }
            }

            public string StaffCategory { get; set; } = string.Empty;
            private int _BasicPay;
            public int BasicPay
            {
                get
                {
                    return _BasicPay;
                }
                set
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Invalid Input...Try Again");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _BasicPay = value;
                }
            }
            private string _City;
            public string City
            {
                get { return _City; }
                set
                {
                    _City = value;
                }
            }

        }

        public class Doctor : Staff
        {
            private string _Specilization;
            public string Specilization
            {
                get { return _Specilization; }
                set
                {
                    _Specilization = value;
                }
            }
            private int _MaxPatientsPerDay;
            public int MaxPatientsPerDay
            {
                get
                {
                    return _MaxPatientsPerDay;
                }
                set
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Invalid Input...Try Again");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _MaxPatientsPerDay = value;
                }
            }
            private int _Fees;
            public int Fees
            {
                get
                {
                    return _Fees;
                }
                set
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Invalid Input...Try Again");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _Fees = value;
                }
            }
        }

        public class Nurse : Staff
        {
            public int Experience { get; set; }
            private int _NoofRoomsVisitedPerDay;
            public int NoofRoomsVisitedPerDay
            {
                get
                {
                    return _NoofRoomsVisitedPerDay;
                }
                set
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Invalid Input...Try Again");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _NoofRoomsVisitedPerDay = value;
                }
            }
        }

        public class Driver : Staff
        {

            public string VehicleType { get; set; } = string.Empty;
            private int _NoOfTripsPerDay;
            public int NoOfTripsPerDay
            {

                get
                {
                    return _NoOfTripsPerDay;
                }
                set
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Invalid Input...Try Again");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _NoOfTripsPerDay = value;
                }
            }
        }
    }

