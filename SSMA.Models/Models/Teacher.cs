using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class Teacher
    {
        [Key]
        public string StaffId { get; set; }
        public Staff Staff { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; } = ManagerialTypeOfStaff.Managerial;
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; } = AcademiceTypeOfStaff.Academic;
    }
}