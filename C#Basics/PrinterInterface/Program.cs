namespace PrinterInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Customer customer = new Customer();
            ProcessInput processinput = new ProcessInput(student);
            processinput.PrintData();
            ProcessInput Processinput2 = new ProcessInput(customer);
            Processinput2.PrintData();
            

        }
    }
}