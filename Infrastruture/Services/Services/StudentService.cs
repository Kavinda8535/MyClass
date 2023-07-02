using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepo;

        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepo.GetAllStudents();
        }
    }
}
