using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Services
{
    public class CourseRegistrationFacadeService : ICourseRegistrationFacadeService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _teacherRepository;

        public CourseRegistrationFacadeService(ICourseRepository courseRepository, IStudentRepository studentRepository, ITeacherRepository teacherRepository)
        {
            _courseRepository = courseRepository;
            _studentRepository = studentRepository;
            _teacherRepository = teacherRepository;
        }

        public void RegisterStudentForCourse(int studentId, int courseId)
        {
            var student = _studentRepository.GetById(studentId);
            var course = _courseRepository.GetById(courseId);

            // Perform necessary checks and validations
            if (student == null || course == null)
            {
                throw new Exception("Invalid student or course.");
            }

            // Register the student for the course
            course.Students.Add(student);
            _courseRepository.Update(course);
        }

        public void AssignTeacherToCourse(int teacherId, int courseId)
        {
            var teacher = _teacherRepository.GetById(teacherId);
            var course = _courseRepository.GetById(courseId);

            // Perform necessary checks and validations
            if (teacher == null || course == null)
            {
                throw new Exception("Invalid teacher or course.");
            }

            // Assign the teacher to the course
            course.Teacher = teacher;
            _courseRepository.Update(course);
        }


    }
}
