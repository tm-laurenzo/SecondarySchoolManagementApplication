using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class HeadOfDeparment : Staff
    {
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; } = ManagerialTypeOfStaff.Managerial;
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; } = AcademiceTypeOfStaff.Academic;
    }
}
