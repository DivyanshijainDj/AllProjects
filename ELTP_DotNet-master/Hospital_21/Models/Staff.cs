using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_21.Models
{
    public class Staff
    {
        public int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
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
        public string Email { get; set; } = String.Empty;
        public string ContactNo { get; set; } = String.Empty;

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


        public string _ShiftStartTime = String.Empty;
        public string ShiftStartTime
        {
            get { return _ShiftStartTime; }
            set
            {
                _ShiftStartTime = value;
            }
        }


        public string _ShiftEndTime = String.Empty;
        public string ShiftEndTime
        {
            get { return _ShiftEndTime; }
            set
            {
                _ShiftEndTime = value;
            }
        }

        public int BasicPay { get; set; }



    }
}
