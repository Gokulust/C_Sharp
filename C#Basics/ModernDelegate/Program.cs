namespace ModernDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modern Delegate Demo");

            Action action = Hello;
            action();

            Action<string> actionWithParameter = Hello;
            actionWithParameter("hello");

            Func<int,int,int> func = Add;
            Func<int> func1 = Add;
            Console.WriteLine(func1());
            Console.WriteLine(func(2,3));
            Predicate<int> predicte = OddOrEven;
            Console.WriteLine(predicte(2));
        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }

        static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        static int Add(int number1,int number2)
        { return number1 + number2; }
        static int Add()
        {
            return 2 + 8;
        }

        static bool OddOrEven(int number)
        {
            if(number%2==0)
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