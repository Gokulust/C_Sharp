namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory (Directory.GetCurrentDirectory()): " + currentDirectory);
            List<int> bids = new List<int> {2,2,2,3,3};
            int count=bids.Count(x=> x == 2);
            string s = "my name is gokul";
            var stringArray=s.Split(' ');
            
            
            Console.WriteLine(s);
            string v = string.Join(" ", stringArray);
            Console.WriteLine(string.Join(" ",stringArray));
            Console.WriteLine(v == s);
            Console.WriteLine(bids.Count());
            Console.WriteLine(count);
            var list = bids.GroupBy(x => x).ToList();
            foreach (var id in list)
            {
                foreach (var b in id) {
                    Console.WriteLine(b);
                }
            }
            
           
            foreach (var v2 in v)
            {
                Console.WriteLine(v2);
            }

            Console.WriteLine(s);
            //List<int> bids = new List<int> {2,2,2,3,3};
            //List<int> temp= new List<int>();
            //temp.AddRange(bids);

           
            //int n = 0;
            //int count = 0;
            //int min;
            //int orgmin = -1;
            //int position = -1;
            //int f = 0;
            //while (n == 0)
            //{
            //    if(temp.Count == 0)
            //    {
            //        f = 1;
            //        break;
            //    }
            //    min = temp.Min();
            //    count = temp.Count(x => x == min);
            //    if (count > 1)
            //    {
            //        temp.RemoveAll(x => x == min);
            //    }
            //    else
            //    {
            //        orgmin = min;
            //        n = 1;
            //    }

            //}
            //if (orgmin != -1)
            //{
            //    position = bids.IndexOf(orgmin);
            //}
            //Console.WriteLine(position);

        }
        public static string MonthName(int num)
        {
            var months = new[] {"January","February","March","April","May","June","July","August","Septemper","October","November","December"};

            return months[num - 1];
        }
    }
}