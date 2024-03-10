namespace CustomAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Retrieving attributes for the class
            Type classType = typeof(MyClass);
            var classAttributes = classType.GetCustomAttributes(typeof(CustomAttribute), true);

            foreach (CustomAttribute attribute in classAttributes)
            {
                Console.WriteLine($"Class Description: {attribute.Description}");
            }

            Console.WriteLine();

            // Retrieving attributes for the method
            var methodInfo = typeof(MyClass).GetMethod("MyMethod");
            var methodAttributes = methodInfo.GetCustomAttributes(typeof(CustomAttribute), true);

            foreach (CustomAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method Description: {attribute.Description}");
            }
        }
    }
    // Custom attribute declaration
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Description { get; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    // Sample class using the custom attribute
    [Custom("This is a sample class.")]
    class MyClass
    {
        [Custom("This is a sample method.")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }
}