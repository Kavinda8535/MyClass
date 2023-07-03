using ApplicationDomain.Entities;
using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var teachers = _teacherService.GetAllTeachers();
            return Ok(teachers);
        }

        [HttpPost]
        public IActionResult AddTeacher([FromBody] Teacher teacher)
        {
            _teacherService.InsertTeacher(teacher);
            return Ok();
        }
    }
}
