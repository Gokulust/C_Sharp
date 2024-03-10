namespace Twice_Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 2, 2, 2, 2, 2 };
            int result = twiceMatch(A);
            Console.WriteLine(result);
        }
        static int twiceMatch(List<int> A)
        {
            int count = 0;
            int mod = 1000000007;
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in A)
            {
                // Check if there is a number in the dictionary whose sum with the current number is a power of 2
                foreach (var pair in frequency)
                {
                    int target = pair.Key;
                    int sum = num + target;
                    if ((sum & (sum - 1)) == 0)
                    {
                        count = (count + pair.Value) % mod;
                    }
                }

                // Increment the frequency of the current number
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            return count;
        }
    
}
}