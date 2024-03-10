namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Method2();
            var cus = (ICustomer2)customer;
            cus.Method2();
            ICustomer2 customer2 = new Customer();
            customer2.Method2();
            customer.Display("gokul");
            customer.LogData("logmessage");

            IInterfaceCustomer customer1 = new Customer();
            customer1.Method2();
            customer1.LogData("message");

            ICustomer3 customer3 = new Customer();
            customer3.Method2();

        }
    }
}