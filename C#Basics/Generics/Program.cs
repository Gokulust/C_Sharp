namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            bool IsEqual = AreEqual<double,int>(10.5,20);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
        public static bool AreEqual<T,S>(T firstNumber, S secondNumber)
        {
            return firstNumber.Equals(secondNumber);
        }


    }
}