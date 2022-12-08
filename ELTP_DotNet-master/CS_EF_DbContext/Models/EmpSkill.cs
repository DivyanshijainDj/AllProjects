using System;
using System.Collections.Generic;

namespace CS_EF_DbFirst.Models
{
    public partial class EmpSkill
    {
        public int ProjectId { get; set; }
        public string Skills { get; set; } = null!;
        public string Experience { get; set; } = null!;
        public int EmpNo { get; set; }

        public virtual Employee EmpNoNavigation { get; set; } = null!;
    }
}
