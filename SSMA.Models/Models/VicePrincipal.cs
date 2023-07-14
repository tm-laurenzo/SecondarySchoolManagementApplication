using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class VicePrincipal : Staff
    {
        public VicePrincipalType VicePrincipalType { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; } = ManagerialTypeOfStaff.Managerial;

    }
}
