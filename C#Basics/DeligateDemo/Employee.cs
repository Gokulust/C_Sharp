using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateDemo
{
    internal class Employee
    {
        public delegate bool IsEligibleForPromotion(Employee employee);
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public int Experience { get; set; }


        public static void GetPromotedEmployees(Employee[] employees,IsEligibleForPromotion isEligibleForPromotion)
        {
            foreach (Employee employee in employees)
            {
                if (isEligibleForPromotion(employee))
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
    }
}
