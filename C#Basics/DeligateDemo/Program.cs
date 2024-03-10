namespace DeligateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee {Id =1,Name="gokul",Salary=1500000,Experience=5 };
            employees[1] = new Employee { Id = 2, Name = "aromal", Salary = 1500000, Experience = 2 };
            employees[2] = new Employee { Id = 3, Name = "maneesh", Salary = 100000, Experience = 3 };

            
            Employee.GetPromotedEmployees(employees,IsPromoted);



        }

         static bool IsPromoted(Employee employee)
        {
            if (employee.Salary >1200000 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}