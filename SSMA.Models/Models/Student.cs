using SSMA.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSMA.Models.Models
{
    public class Student:BaseGuidEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public Class Class { get; set; }
        public List<Subject> Subjects { get; set; }
        public AppUser AppUser { get; set; }
    }
}
