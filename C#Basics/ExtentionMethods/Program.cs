namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            
            Console.WriteLine($"Is {num1} even? {num1.IsEven()}");
            Console.WriteLine($"Is {num1} odd? {num1.IsOdd()}");
            Console.WriteLine($"Square of {num1}: {num1.Square()}");

            int num2 = 7;
            Console.WriteLine($"Is {num2} even? {num2.IsEven()}");
            Console.WriteLine($"Is {num2} odd? {num2.IsOdd()}");
            Console.WriteLine($"Square of {num2}: {num2.Square()}");

            Console.WriteLine(IntegerExtensions.IsEven(num1));
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsEven(this int number) //IsEven method is defined as an extension method for the int type
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static int Square(this int number)
        {
            return number * number;
        }
    }
}