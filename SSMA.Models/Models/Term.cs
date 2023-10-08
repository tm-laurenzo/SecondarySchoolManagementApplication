﻿using SSMA.Models.Base;
using SSMA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Term : BaseGuidEntity
    {
        public Session Session { get; set; }
        public TermNumber TermNumber { get; set; }
    }
}
