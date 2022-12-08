using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;

        public string gender { get; set; }

        public string DOB { get; set; }

        public int contact { get; set; }

    }

    public class Doctor : Staff
    {
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }

    public class Nurse : Staff
    {
        public int Experience { get; set; }

        public int patientmonitor { get; set; }
    }

    public class Driver : Staff
    {
        public string VehicleType { get; set; }

        public int experience {get; set;}

    }

}