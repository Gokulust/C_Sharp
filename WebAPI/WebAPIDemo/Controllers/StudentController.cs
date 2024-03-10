using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebAPIDemo.Models;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentInterface _studentService;
        public StudentController(IStudentInterface studentService) {
            _studentService = studentService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            List<Student> studentList = _studentService.GetStudents();
            if (studentList.Count == 0)
            {
                return NotFound("No record Found");
            }
            return Ok(studentList);
        }
        [HttpGet("StartWithA")]
        public string GetStudentStartWithA()
        {

            return "StartsWithA";
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {

            IEnumerable<Student> studentsList = _studentService.AddStudent(student);
            return Ok(studentsList);
        }

        [HttpDelete("{studentId}")]

        public IActionResult Delete(string studentId) {

            if (_studentService.DeleteStudent(int.Parse(studentId)))
            {
                return Ok("Student Record Deleted successfully");
            }
            return NotFound("k");
        }

        [HttpPut("{studentId}")]
        public IActionResult Update(int studentId, [FromBody] Student Student)
        {
            if(_studentService.IsStudentIdPresent(studentId))
            {
                if(_studentService.UpdateStudent(studentId,Student))
                {
                    return Ok("Student first name is updated");
                }
                return NotFound("not found");
            }
            else
            {
                return NotFound("Id not found");
            }
        }



    }


}
