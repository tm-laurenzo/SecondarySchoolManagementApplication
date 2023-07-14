using SSMA.Models.Base;

namespace SSMA.Models.Models
{
    public class Exam : BaseGuidEntity
    {
        public int Score { get; set; }
        public DateTime DateOfExam { get; set; }

    }
}
