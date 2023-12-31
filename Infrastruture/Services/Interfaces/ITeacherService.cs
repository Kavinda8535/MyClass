﻿using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Interfaces
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAllTeachers();
        void InsertTeacher(Teacher teacher);
    }
}
