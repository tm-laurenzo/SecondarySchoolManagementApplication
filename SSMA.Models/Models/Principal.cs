using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Principal : Staff
    {
        public new ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; } = ManagerialTypeOfStaff.Managerial;
        public new AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; } = AcademiceTypeOfStaff.Academic;
    }
}
