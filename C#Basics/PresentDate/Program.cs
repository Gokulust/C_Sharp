namespace PresentDate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var day = DateTime.Now.DayOfWeek;
            Console.WriteLine($"present day is {day}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
        }
    }
}