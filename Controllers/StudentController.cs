using Microsoft.AspNetCore.Mvc;

namespace Student.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase

{

    private StudentDbContext _context;

    public StudentController(StudentDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Students> Get()
    {
        var returnValue = _context.Students.ToList();
        return returnValue;
    }
}