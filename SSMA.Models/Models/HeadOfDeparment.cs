using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class HeadOfDeparment : Staff
    {
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; } = ManagerialTypeOfStaff.Managerial;
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; } = AcademiceTypeOfStaff.Academic;
    }
}
