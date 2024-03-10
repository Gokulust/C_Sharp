namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 111, 223, 456, 40037 };
            int count = 0;

            foreach (int i in list)
            {
                string a=i.ToString();
                Console.WriteLine(a);
                foreach (var j in a)
                {
                    if (j=='3'|| j=='4' || j=='7')
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

            }
        }
    }
}
