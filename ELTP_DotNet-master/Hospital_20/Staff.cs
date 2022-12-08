using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hospital_20
{
    /// <summary>
    /// Pure ENtity Class or DTO or VO
    /// </summary>
    public class Staff
    {
        // Private Data Members 
        public int _StaffId;
        public int StaffId
        {
            get { return _StaffId;}
            set
            {
                if (value <= 0)
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Invalid!! Enter Positive Value\n");
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


        public string? _StaffName = String.Empty;
        public string? StaffName
        {
            get { return _StaffName; }
            set
            {
                int count = 0;
                bool flag = true;
                while (flag)
                {
                    string? specialChar = "\"@|!#$%&/()=?{}.-;~`'<>_,";
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
                        Console.WriteLine("Invalid! Please enter Alphabets only");
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


        public string? _Email = String.Empty;
        public string? Email
        {
            get
            {
                return _Email;
            }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value == String.Empty)
                    {
                        Console.WriteLine("Please enter Email");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _Email = value;
                        flag = false;
                    }

                }
                //_Email = value; 
            }
        }

        List<String> DptList = new List<String>() { "Cancer", "Heart", "Pathology", "Radiology", "Bloob Bank", "Organs", "Orthopeic", "Eye", "Dental" };

        public string _DeptName = String.Empty;
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
        public string _Gender = String.Empty;
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

       
        public DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                while ((DateTime.Now.Year - value.Year) < 25)
                {
                    Console.WriteLine("Enter the DOB Again ( At Least 25 Years Old )- eg yyyy mm dd ");
                    value = Convert.ToDateTime(Console.ReadLine());
                }

                _DateOfBirth = value;
            }
        }


        public string _StaffCategory = String.Empty;
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


        public string _Education = String.Empty;
        public string? Education
        {
            get { return _Education; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value == String.Empty)
                    {
                        Console.WriteLine("Please enter Education");
                        Console.WriteLine("Enter  Education");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _Education = value;
                        flag = false;
                    }

                }
                //_Education = value;
            }
        }


        public int _ContactNo;
        public int ContatNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }


        public string _ShiftStartTime=String.Empty;
        public string ShiftStartTime
        {
            get { return _ShiftStartTime; }
            set
            {
                _ShiftStartTime = value;
            }
        }


        public string _ShiftEndTime= String.Empty;
        public string ShiftEndTime
        {
            get { return _ShiftEndTime; }
            set
            {
                _ShiftEndTime = _ShiftStartTime;
            }
        }


        public Double _BasicPay;
        public Double BasicPay
        {
            get { return _BasicPay; }
            set
            {
                _BasicPay = value;
            }
        }
    }

}