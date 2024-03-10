namespace Delegates
{
    internal class Program
    {
        delegate void MyFirstDelegate();
        delegate void MySecondDelegate(string message);
        delegate int MyThirdDelegate(int number1,int number2);
        delegate int MyFourthDelegate(int number1,int number2);
        
        static void Main(string[] args)
        {
            
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(Display);
            MyFirstDelegate myFirstDelegate2 = new MyFirstDelegate(Display2);
            myFirstDelegate();
            MySecondDelegate mySecondDelegate = new MySecondDelegate(Print);
            mySecondDelegate("hello");
            var myThirdDelegate = new MyThirdDelegate(DisplaySum);
            int sum = myThirdDelegate(2, 3);
            Console.WriteLine(sum);

            
        }

        static void Display()
        {
            Console.WriteLine("Display method");
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Display2()
        {
            Console.WriteLine("display2");
        }

        static int DisplaySum(int number1,int number2)
        {
            return number1 + number2;
        }
    }

    class Program2
    {
        public void Display2()
        {
            Program program = new Program();
           
        }
    }


}