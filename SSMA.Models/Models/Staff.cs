using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class Staff : AppUser
    {
        [Key]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessPhone { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; }
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; }

    }
}
