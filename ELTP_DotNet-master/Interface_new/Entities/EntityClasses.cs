using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_new.Models;

namespace Interface_new.Entities
{
    public class Staff
    {
        private string _StaffId;
        List<String> DptList = new List<String>() { "Cancer", "Heart", "Pathology", "Radiology", "Bloob Bank", "Organs", "Orthopeic", "Eye", "Dental" };
        public string StaffId
        {
            get { return _StaffId; }
            set
            {
                if (value <= 0)
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Enter Non Negative Value\n");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value > 0)
                        {
                            _StaffId = value;
                            flag = false;
                        }
                    }
                }
                else
                {
                    _StaffId = value;
                }
            }
        }


        private string? _StaffName = String.Empty;
        public string? StaffName
        {
            get { return _StaffName; }
            set
            {
                int count = 0;
                bool flag = true;
                while (flag)
                {
                    string? specialChar = "\"@|!#$%&/()=?»«@£§€{}.-;~`'<>_,";
                    foreach (char item in value)
                    {
                        if (specialChar.Contains(item))
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Please enter Alphabets only");
                        value = Console.ReadLine();
                        count = 0;
                    }
                    else
                    {
                        _StaffName = value;
                        flag = false;

                    }

                }
            }
        }


        private string _DeptName = String.Empty;
        public string? DeptName
        {
            get { return _DeptName; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (!DptList.Contains(value))
                    {
                        Console.WriteLine("Please enter correct department");
                        Console.WriteLine("Enter department name");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _DeptName = value;
                        flag = false;
                    }

                }
                //_DeptName = value;
            }
        }


        private string _Gender = String.Empty;
        public string? Gender
        {
            get { return _Gender; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value == String.Empty)
                    {
                        Console.WriteLine("Please enter Gender");
                        Console.WriteLine("Enter  Gender");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _Gender = value;
                        flag = false;
                    }

                }
                //_Gender = value;
            }
        }


        private DateOnly _DateOfBirth;
        public DateOnly DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {

                _DateOfBirth = value;
            }
        }

        private Double _BasicPay;
        public Double BasicPay
        {
            get { return _BasicPay; }
            set
            {
                _BasicPay = value;
            }
        }

        private string _StaffCategory = String.Empty;
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set
            {
                List<String> stflist = new List<String>() { "Doctor", "Nurse", "Wardnboy", "Brother", "Technician" };
                bool flag = true;
                while (flag)
                {
                    if (!stflist.Contains(value))
                    {
                        Console.WriteLine("Please enter correct Staff Category");
                        Console.WriteLine("Enter Category name");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _StaffCategory = value;
                        flag = false;
                    }

                }
                //_StaffCategory = value;
            }
        }
    }

    public class Doctor : Staff
    {
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }

    public class Nurse : Staff
    {
        public int Experience { get; set; }
    }

    public class Driver : Staff
    {
        public string VehicleType { get; set; }
    }

}