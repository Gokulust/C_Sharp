namespace ToString
{
     internal class Program
    {
       
        static void Main(string[] args)
        {
            string stringValue= "Gokulll";
            Console.WriteLine(stringValue[1]);
            var distinct = stringValue.Distinct().ToArray();
            Console.WriteLine(distinct);
            int x = 222;
          
            while(x<225)
            {
               // Console.WriteLine(x);
                //x++;
                x++;
     
                //y = x++;
                Console.WriteLine(x);
                //Console.Write(y);
            }

            Person person = new Person { Id =1,Name="Gokul"};
            //Console.WriteLine(person.ToString());


        }
    }

    class Person
    {
        public override string ToString()
        {
            return $"{Id},{Name}";
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

   
}