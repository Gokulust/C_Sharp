using System.IO;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the city");
            string cityName=Console.ReadLine();
            Console.WriteLine(cityName.Contains("t"));
            List<string> resultList = new List<string>();
            string path = "File.txt";
            string read;
            using (StreamReader readtext = new StreamReader(path))
            {
                 read = readtext.ReadToEnd();
              
            }
            var arr=read.Split('.');
            foreach (string s in arr)
            {
                var split = s.Split("-");
                foreach (string s2 in split)
                {
                    if (s2 == cityName)
                    {

                        resultList.Add(split[0]);
                    }
                }

            }
            foreach (string result in resultList)
            {
                Console.WriteLine(result);
            }
        }
    }
}