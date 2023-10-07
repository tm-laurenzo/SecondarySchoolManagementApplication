using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class Principal
    {
        [Key]
        public String StaffId { get; set; }
        public Staff Staff { get; set; }
        public new ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; } = ManagerialTypeOfStaff.Managerial;
        public new AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; } = AcademiceTypeOfStaff.Academic;
        public DateTime PostionStartDate { get; set; }
        public DateTime PostionEndtDate { get; set; }
    }
}
