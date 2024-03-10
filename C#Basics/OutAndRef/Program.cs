namespace OutAndRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 5;
            int num2 = 3;
            int resultSum;
            int product = 0;


        CalculateSumAndProduct(num1, num2, out resultSum, out product);

            Console.WriteLine("Sum: " + resultSum);         
            Console.WriteLine("Product: " + product);
           
      
            Console.WriteLine($"{ConvertStringToInt("123",out int result)},{result}");

            //*************Ref**********//

            // Calling the method and swapping values
            int x = 5;
            int y = 10;

            Swap(ref x, ref y);

            Console.WriteLine("x: " + x); // Output: x: 10
            Console.WriteLine("y: " + y); // Output: y: 5
        }
        
        static void CalculateSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        static bool ConvertStringToInt(string value, out int result)
        {
            try
            {
                result = int.Parse(value);
                return true;
            }
            catch
            {
                result = 0; return false;
            }
        }
       static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        
    }
}