﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class Course : BaseEntity
    {
            public string? CourseName { get; set; }
            public string? CourseDescription { get; set; }
            public int TeacherId { get; set; }
            public ICollection<Student>? Students { get; set; }
            public Teacher? Teacher { get; set; }
    }   
}
