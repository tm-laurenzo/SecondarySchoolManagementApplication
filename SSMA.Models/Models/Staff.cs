using SSMA.Models.Base;
using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSMA.Models.Models
{
    public class Staff : BaseGuidEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessPhone { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; }
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; }

    }
}
