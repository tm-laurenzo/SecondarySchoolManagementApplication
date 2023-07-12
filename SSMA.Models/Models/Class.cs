using SSMA.Models.Base;
using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Class : BaseGuidEntity
    {
        public ClassColour Colour { get; set; }
        public ClassColour Level { get; set; }
    }
}
