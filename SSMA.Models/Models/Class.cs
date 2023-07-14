using SSMA.Models.Base;
using SSMA.Models.Enums;

namespace SSMA.Models.Models
{
    public class Class : BaseGuidEntity
    {
        public ClassColour Colour { get; set; }
        public ClassColour Level { get; set; }
    }
}
