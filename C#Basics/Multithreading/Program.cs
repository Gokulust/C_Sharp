namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //Console.WriteLine(t);
            ////By Default, the Thread does not have any name
            ////if you want then you can provide the name explicitly
            //t.Name = "Main Thread";
            //Console.WriteLine("Current Executing Thread Name :" + t.Name);
            //Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
            //Thread threadOne = new Thread(MethodOne);
            //Thread threadTwo = new Thread(MethodTwo);
            //threadOne.Name = "Thread One";
            //threadTwo.Name = "Thread two";
            //threadOne.Start();
            //threadTwo.Start();
            Program obj = new Program();
            ParameterizedThreadStart PTSD = new ParameterizedThreadStart(DisplayNumbers);
            Thread t1 = new Thread(PTSD);
            t1.Start(6);
            Console.Read();


        }
        public static void DisplayNumbers(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        static void MethodOne()
        {

            Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
        }

        static void MethodTwo()
        {
            Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}