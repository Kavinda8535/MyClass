using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[RoutePrefix("Assignment")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [Route("pickrandomchar")] // https://localhost:7296/api/assignment/pickrandomchar
        [HttpPost]
        public IActionResult PickRandomCharacters([FromBody] String value)
        {
            var result = _assignmentService.PickFiveRandomStringValues(value);
            return Ok(result);
        }
    }
}
