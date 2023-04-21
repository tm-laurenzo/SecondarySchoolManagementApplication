using SSMA.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Exam: BaseGuidEntity
    {
        public int Score { get; set; }
        public DateTime DateOfExam { get; set; }

    }
}
