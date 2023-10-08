using SSMA.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Session : BaseGuidEntity
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
