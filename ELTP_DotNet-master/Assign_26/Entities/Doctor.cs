using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_26.Entities
{
    public class Doctor : Staff
    {
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }
}
