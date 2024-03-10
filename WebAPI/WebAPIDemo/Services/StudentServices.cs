using System.Reflection.Metadata.Ecma335;
using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public class StudentServices:IStudentInterface
    {
         List<Student> students = new List<Student>();
        public List<Student> GetStudents ()
        {
            return students;
        }
        public IEnumerable<Student> AddStudent(Student student)
        {
            student.Id = students.Any() ? students.Max(x => x.Id) + 1 : 1;
            students.Add(student);
            return students;
        }

        public bool DeleteStudent(int studentId)
        {
            students.Remove(students.Find(student=>student.Id==studentId)); 
            return true;
        }

        public bool UpdateStudent(int studentId,Student student)
        {
            var objectToUpdate=students.Find(students=>students.Id==studentId);
            objectToUpdate.Id = studentId;
            objectToUpdate.FirstName = student.FirstName;
            objectToUpdate.LastName = student.LastName;
            objectToUpdate.Age= student.Age;
            return true;
        }
        public bool IsStudentIdPresent(int studentId)
        {
            if(students.Find(student=>student.Id == studentId) == null)
            {
                return false;
            }
            return true;
        }
    }
}
