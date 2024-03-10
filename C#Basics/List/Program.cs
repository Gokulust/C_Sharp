namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student studentOne = new Student { Id = 1 ,Name="Teena",Marks=89};
           Student studentTwo = new Student { Id = 2, Name = "Gokul", Marks = 97 };
           Student studentThree = new Student { Id = 3, Name = "Rithu", Marks = 89 };

           List<Student> studentList = new List<Student>() { studentOne,studentTwo,studentThree};
           
         

            var failedStudentList = studentList.FindAll(student => student.Marks > 80);

            foreach (Student student in failedStudentList)
            {

                Console.WriteLine(student.Marks);
            }
            var studentListStartsWith = studentList.FindAll(student => student.Name.StartsWith("G"));
            foreach (Student student in studentListStartsWith)
            {

                Console.WriteLine($"{student.Id},{student.Name},{student.Marks}");
            }

            var studentStartAndEnd = studentList.FindAll(student =>
            {
                if (student.Name.StartsWith("G") && student.Marks > 80)
                {
                    return true;
                }
                return false;
            });
            foreach (Student student in studentStartAndEnd)
            {

                Console.WriteLine($"{student.Id},{student.Name},{student.Marks}");
            }
        }


    }

    
   
}