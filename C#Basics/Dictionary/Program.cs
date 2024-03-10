namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary is a collection class that represents a generic collection of key-value pairs
            // Create a new Dictionary
            Dictionary<string, string> countries = new Dictionary<string, string>() {

                { "US","United States" },
                {"CA","Canada" },
                {"UK","United Kingdom" }
            };

            // Add key-value pairs to the Dictionary
            //countries["CA"] = "Canada";
            countries["SA"] = "South Africa";

            // Access values using keys
            string usFullName = countries["US"];
            Console.WriteLine("Full name of US: " + usFullName);

            // Check if a key exists in the Dictionary
            if (countries.ContainsKey("CA"))
            {
                Console.WriteLine("Full name of CA: " + countries["CA"]);
            }

            // Iterate over the key-value pairs
            foreach (KeyValuePair<string, string> kvp in countries)
            {
                Console.WriteLine("Country code: " + kvp.Key + ", Name: " + kvp.Value);
            }

            // Remove a key-value pair
            countries.Remove("UK");

            // Clear all key-value pairs
            countries.Clear();
        }
    }
}