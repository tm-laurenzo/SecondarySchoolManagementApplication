using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class Subject : SubjectName
    {
        public Exam Exam { get; set; }
        public List<Test> Tests { get; set; }
        public List<Assignment> Assignments { get; set; }
        public Teacher Teacher { get; set; }
        public Term Term { get; set; }

    }
}
