using SSMA.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSMA.Models.Models
{
    public class Department: BaseGuidEntity
    {
        public string NameOfDepartment { get; set; }
        public List<SubjectName> Subjects { get; set; }
        public HeadOfDeparment HeadOfDeparment { get; set; }
    }
}
