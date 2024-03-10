using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public interface IStudentInterface
    {
        List<Student> GetStudents();
        IEnumerable<Student> AddStudent(Student student);

        bool UpdateStudent(int studentId,Student student);
        bool DeleteStudent(int studentId);

        bool IsStudentIdPresent(int studentId);
    }
}
