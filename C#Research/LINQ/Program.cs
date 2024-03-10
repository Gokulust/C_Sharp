namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sample data - a list of cars
            List<Car> cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Camry", Year = 2018 },
            new Car { Make = "Honda", Model = "Civic", Year = 2017 },
            new Car { Make = "Ford", Model = "Mustang", Year = 2020 },
            
        };

            // Query syntax
            var toyotaCarsQuery = from car in cars
                                  where car.Make == "Toyota"
                                  select car;

            Console.WriteLine("Toyota cars:");
            foreach (var car in toyotaCarsQuery)
            {
                Console.WriteLine($"{car.Make} {car.Model} ({car.Year})");
            }

            // Method syntax
            var toyotaCarsMethod = cars.FindAll(car => car.Make == "Toyota");

            Console.WriteLine("\nToyota cars");
            foreach (var car in toyotaCarsMethod)
            {
                Console.WriteLine($"{car.Make} {car.Model} ({car.Year})");
            }
        }
    }
}