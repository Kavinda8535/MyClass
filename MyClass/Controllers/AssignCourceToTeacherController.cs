using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyClass.Model;

namespace MyClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignCourceToTeacherController : ControllerBase
    {
        private readonly ICourseRegistrationFacadeService _courseRegistrationFacadeService;

        public AssignCourceToTeacherController(ICourseRegistrationFacadeService courseRegistrationFacadeService)
        {
            _courseRegistrationFacadeService = courseRegistrationFacadeService;
        }

        [HttpPost]
        public IActionResult AssignTeacherToCourse([FromBody] AssignmentData assignmentData)
        {
            _courseRegistrationFacadeService.AssignTeacherToCourse(assignmentData.TeacherId, assignmentData.CourseId);
            return Ok();
        }
    }
}
