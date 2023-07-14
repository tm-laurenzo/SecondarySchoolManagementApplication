using SSMA.Models.Base;


namespace SSMA.Models.Models
{
    public class Department : BaseGuidEntity
    {
        public string NameOfDepartment { get; set; }
        public List<SubjectName> Subjects { get; set; }
        public HeadOfDeparment HeadOfDeparment { get; set; }
    }
}
