﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Models.Models
{
    public class Student: AppUser
    {
        public Class Class { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}