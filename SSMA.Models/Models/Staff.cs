using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Staff : AppUser
    {
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; }
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; }
    }
}
