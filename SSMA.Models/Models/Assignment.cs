using SSMA.Models.Base;

namespace SSMA.Models.Models
{
    public class Assignment : BaseGuidEntity
    {
        public int Score { get; set; }
        public DateTime DateOfAssignment { get; set; }
    }
}
