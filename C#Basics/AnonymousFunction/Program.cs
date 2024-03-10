namespace AnonymousFunction
{
    internal class Program
    {
        public delegate void Petanim(string pet);
        public delegate void Show(string color);
        static void Main(string[] args)
        {
            string favourite = "favorite";
            Petanim p = delegate (string pet)
            {
                Console.WriteLine($" my {favourite} pet is {pet}");
            };
            Action<string,string> action = (petOptionOne,petOptionTwo) => { Console.WriteLine("my pets are {0} and {1}",petOptionOne,petOptionTwo); };
            Func<int,int,int> func =(number1, number2) => { return number1+number2; };
            int result = func(3,7);
            Console.WriteLine(result);
            Predicate<String> predicate =(name) =>{ if(name == "gokul") {return true;} return false; };
            bool boolResult = predicate("rithu");
            Console.WriteLine(boolResult);

            action("dog","cat");
            p("cat");

            
            identity(delegate (string color) { Console.WriteLine($"Color of my dog is {color}"); }, "Blue");

        }
        static void identity(Show pet , string color)
        {
            
            pet(color);
        }
    }
}