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

        public Student GetById(int studentId)
        {
            return _applicationDbContext.Students.Where(c => c.Id == studentId).FirstOrDefault();
           //.Include(c => c.Id)
           //.FirstOrDefault(c => c.Id == studentId);
        }
    }
}
