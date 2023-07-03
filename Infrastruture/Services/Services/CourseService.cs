using ApplicationDomain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public void InsertCourse(Course course)
        {
            _courseRepository.InsertCourse(course);
        }
    }
}
