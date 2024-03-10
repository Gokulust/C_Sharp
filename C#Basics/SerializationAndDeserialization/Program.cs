using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SerializationAndDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serialize object to a file
            TestClass myObject = new TestClass(42, "Hello");
            string filePath = "C:\\test\\serialize.txt";

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, myObject);
            }

            Console.WriteLine("Object serialized.");

            //Serialize object to Json

            //JsonSerializer is a class from the System.Text.Json
            string json = JsonSerializer.Serialize(myObject);
            Console.WriteLine("Object serialized to JSON:");
            Console.WriteLine(json);

           // Deserialize object from the file
            TestClass deserializedObject;
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                deserializedObject = (TestClass)formatter.Deserialize(stream);
                
            }

            Console.WriteLine($"Deserialized Object: {deserializedObject.TestProperty}, {deserializedObject.TestField}");

            // Deserialize object from the Json
            TestClass deserializedObjectJson = JsonSerializer.Deserialize<TestClass>(json);

            Console.WriteLine("Object deserialized from JSON:");
            Console.WriteLine($"TestProperty: {deserializedObjectJson.TestProperty}");
            Console.WriteLine($"TestField: {deserializedObjectJson.TestField}");
            
        }

    }
    }
