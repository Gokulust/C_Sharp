namespace MostSpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {11,43225,12342,34252,4612,54532,41753,12327,53134,16435,32532,12122};

            var distinctArray = array.Where(x=>x.ToString().Distinct().Count()==x.ToString().Length).ToArray();
            
           foreach(bool x in distinctArray)
            {
                Console.WriteLine(x);
            }
            
            
        }
    }
}