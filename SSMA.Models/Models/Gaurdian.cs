namespace SSMA.Models.Models
{
    public class Gaurdian : AppUser
    {
        public string Name { get; set; }
        public List<Student> StudentsOfGaurdian { get; set; }
    }
}
