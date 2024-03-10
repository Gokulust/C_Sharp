namespace Dynamicpolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle vehicle = new Vehicle();
            Vehicle carVehicle = new Car();
            Vehicle busVehicle = new Bus();

            vehicle.Drive();
            carVehicle.Drive();
            busVehicle.Drive();
        }
    }

    class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving a Vehicle");
        }
    }
    class Car:Vehicle
    {
        public override  void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
    class Bus:Vehicle
    {
        public override  void Drive()
        {
            Console.WriteLine("Driving a Bus");
        }
    }


}