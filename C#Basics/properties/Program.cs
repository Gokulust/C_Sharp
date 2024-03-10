namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Student student = new Student();
            student.Id = 2;
            Console.WriteLine(student.Id);
            Console.WriteLine(student.PassMark);
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            student.Name = name;
        }
    }
}