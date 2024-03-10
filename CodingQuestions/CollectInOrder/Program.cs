namespace CollectInOrder
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool left=true;
            bool right=false;
            int count = 0;
            List<int> Perm = new List<int>() {2,3,1};
            List<int> myList = new List<int> { 2, 3, 1 };
            List<int> indexList = myList.Select((item) => myList.IndexOf(item)).ToList();
            List<int> list = new List<int>();

           for (int i = 1;i<=Perm.Count();i++)
            {
                list.Add(Perm.IndexOf(i));
            }
            for (int i = 0; i < Perm.Count(); i++)
            {
                if(left)
                {
                    if (Perm[i] < Perm[i+1]) {
                        count++;
                    }
                }
            }



            //int N = 3;

            //int n = 1;
            //int j = 1;
            //int i = -1;
            //int count = 1;
            //bool fwd = true;
            //bool bwd = false;
            //while (n == 1)
            //{   
            //    while (fwd)
            //    {
            //        i++;
            //        if (Perm[i] == j)
            //        {
            //            j++;
            //        }

            //        if (i == N - 1)
            //        {
            //            fwd = false;
            //            bwd = true;
            //        }

            //        if (N == j)
            //        {
            //            bwd = false;
            //            n = 0;
            //        }

            //    }
            //    count++;
            //    while (bwd)
            //    {
            //        i--;
            //        if (Perm[i] == j)
            //        {
            //            j++;
            //        }
            //        if (i == 0)
            //        {
            //            bwd = false;
            //            fwd = true;
            //        }
            //        if (N == j)
            //        {
            //            fwd = false;
            //            n = 0;
            //        }
            //    }


            //}
            //Console.Write(count);
            //Console.WriteLine(j);
        }
    }
}