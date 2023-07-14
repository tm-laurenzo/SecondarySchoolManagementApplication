using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class Staff : AppUser
    {
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; }
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; }
    }
}
