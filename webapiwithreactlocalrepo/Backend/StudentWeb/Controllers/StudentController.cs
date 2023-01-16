using Microsoft.AspNetCore.Mvc;
using DAL;
using Model;
using Microsoft.AspNetCore.Cors;

namespace StudentWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
   

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Student> GetAllStudent()
    {
        List<Student> student=StudentAcces.GetAllStudent();
        return student;
    }

    [HttpPost]
    [EnableCors()]

    public IActionResult InsertNewUser(Student student)
    {
        StudentAcces.InsertNewUser(student);
        return Ok(new { message = "user created"});
    }

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]

    public ActionResult<Student> DeleteOneStudent(int id)
    {
        StudentAcces.DeleteById(id);
        return Ok(new {message="user deleted"});
    }
}
