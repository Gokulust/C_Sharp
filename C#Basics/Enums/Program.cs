namespace Enums
{
    internal class Program
    {
        enum year
        {
            Jan, Feb, Mar, Apr, May, Jun, Jul,
            Aug, Sep, Oct, Nov, Dec
        };
        static void Main(string[] args)
        {
            string data = null;
            Console.WriteLine(data.ToString());
            Console.WriteLine(Convert.ToString(data));
            Console.WriteLine(year.Jan);
            Console.WriteLine((int)year.Jan);
            for(int i=(int)year.Jan;i<=(int)year.Dec;i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}