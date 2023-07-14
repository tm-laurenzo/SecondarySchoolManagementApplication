namespace SSMA.Models.Models
{
    public class Student : AppUser
    {
        public Class Class { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
