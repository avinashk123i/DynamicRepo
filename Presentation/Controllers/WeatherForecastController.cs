using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Abstractions;

namespace Clean.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IServiceManager _serviceManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IServiceManager serviceManager
           )
        {
            _logger = logger;
            _serviceManager = serviceManager;
        }

        [HttpGet(Name = "GetTeachers")]
        public async Task<IEnumerable<TeacherDTO>> GetTeachers()
        {
            return await _serviceManager.teacherService.GetTeachers();
        }


        [HttpPost(Name = "CreateTeacher")]

        public IActionResult CreateTeachers(TeacherDTO teacher)
        {
            try
            {
                _serviceManager.teacherService.CreateTeacher(teacher);

                return Ok("created");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
