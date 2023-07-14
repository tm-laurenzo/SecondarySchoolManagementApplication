using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class Principal : Staff
    {
        public new ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; } = ManagerialTypeOfStaff.Managerial;
        public new AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; } = AcademiceTypeOfStaff.Academic;
    }
}
