using ApplicationDomain.Entities;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void InsertStudent(Student student)
        {
            _applicationDbContext.Students.Add(student);
            _applicationDbContext.SaveChanges();

        }

        IEnumerable<Student> IStudentRepository.GetAllStudents()
        {
            return _applicationDbContext.Students.ToList();
        }


    }
}
