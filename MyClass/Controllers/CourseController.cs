using ApplicationDomain.Entities;
using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courses = _courseService.GetAllCourses();
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            _courseService.InsertCourse(course);
            return Ok();
        }
    }
}
