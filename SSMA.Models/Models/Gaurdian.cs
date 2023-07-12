using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Gaurdian : AppUser
    {
        public string Name { get; set; }
        public List<Student> StudentsOfGaurdian { get; set; }
    }
}
