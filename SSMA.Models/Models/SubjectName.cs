using SSMA.Models.Base;

namespace SSMA.Models.Models
{
    public class SubjectName : BaseGuidEntity
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
