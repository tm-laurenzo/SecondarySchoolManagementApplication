using SSMA.Models.Base;
using SSMA.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSMA.Models.Models
{
    public class Staff
    {
        [Key]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Teacher Teacher { get; set; }
        public Principal Principal { get; set; }
        public VicePrincipal VicePrincipal { get; set; }
        public ManagerialTypeOfStaff ManagerialTypeOfStaff { get; set; }
        public AcademiceTypeOfStaff AcademiceTypeOfStaff { get; set; }

    }
}
