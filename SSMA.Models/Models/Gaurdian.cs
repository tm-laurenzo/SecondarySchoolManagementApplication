using System.ComponentModel.DataAnnotations;

namespace SSMA.Models.Models
{
    public class Gaurdian
    {
        [Key]
        public String StaffId { get; set; }
        public Staff Staff { get; set; }
        public string Name { get; set; }
        public List<Student> StudentsOfGaurdian { get; set; }
    }
}
