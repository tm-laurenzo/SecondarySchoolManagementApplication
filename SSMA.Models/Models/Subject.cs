using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public Exam Exam { get; set; }
        public List<Test> Tests { get; set; }
        public List<Assignment> Assignments { get; set; }
        public Teacher Teacher { get; set; }
        public Term Term { get; set; }

    }
}
