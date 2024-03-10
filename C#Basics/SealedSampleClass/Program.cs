namespace SealedSampleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            int array_length = 5;
            List<int> arr = new List<int>() { 1,2,3,4,5,6};
            int sumCouple = 0;
            int score = 0; 
            for (int i = 0; i < array_length - 2; i++) 
            { 
                int j = i + 1; 
                sumCouple = arr[i] + arr[j];
                if (sumCouple % 2 == 0) 
                {
                    score += 5;
                }
            }
            int tripleSum = 0;
            int triplePdt = 0;    
            for (int j = 0; j <=array_length - 3; j++) 
            { 
                
                    tripleSum += arr[j] + arr[j + 1] + arr[j+2]; 
                    triplePdt *= arr[j] * arr[j + 1] + arr[j+2]; 
                
                if (tripleSum % 2 != 0 && triplePdt % 2 == 0) 
                { score += 10; }
            }
            if (score != 0) Console.WriteLine(score); else Console.Write(score);
        }

    }
    
    sealed class Person
    {
        public int Id { get; set; }
    }
}
