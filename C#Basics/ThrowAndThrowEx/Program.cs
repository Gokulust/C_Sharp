namespace ThrowAndThrowEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionOne();
        }

        static void FunctionOne()
        {
            try
            {
                FunctionTwo();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        static void FunctionTwo()
        {
            throw new Exception();
        }
    }
}