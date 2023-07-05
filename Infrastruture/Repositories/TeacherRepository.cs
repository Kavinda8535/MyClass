using ApplicationDomain.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TeacherRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _applicationDbContext.Teachers.ToList();
        }

        public void InsertTeacher(Teacher teacher)
        {
            _applicationDbContext.Teachers.Add(teacher);
            _applicationDbContext.SaveChanges();
        }

        public Teacher GetById(int teacherId)
        {
            return _applicationDbContext.Teachers
           .Include(c => c.Id)
           .FirstOrDefault(c => c.Id == teacherId);
        }
    }
}
