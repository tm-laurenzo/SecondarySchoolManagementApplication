using SSMA.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class SubjectName: BaseGuidEntity
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
