using Infrastructure.Services.Interfaces;
using Infrastructure.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyClass.Model;

namespace MyClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseRegistrationController : ControllerBase
    {
        private readonly ICourseRegistrationFacadeService _courseRegistrationFacadeService;

        public StudentCourseRegistrationController(ICourseRegistrationFacadeService courseRegistrationFacadeService)
        {
            _courseRegistrationFacadeService = courseRegistrationFacadeService;
        }

        [HttpPost]
        public IActionResult RegisterStudentForCourse([FromBody] RegistrationData registrationData)
        {
            _courseRegistrationFacadeService.RegisterStudentForCourse(registrationData.StudentId, registrationData.CourseId);
            return Ok();
        }

    }
}
