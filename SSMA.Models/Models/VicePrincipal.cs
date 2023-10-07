using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class VicePrincipal
    {
        [Key]
        public String StaffId { get; set; }
        public Staff Staff { get; set; }
        public VicePrincipalType VicePrincipalType { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; } = ManagerialTypeOfStaff.Managerial;

    }
}
