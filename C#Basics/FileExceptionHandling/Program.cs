namespace FileExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader? streamReader=null, streamReader1=null;
            try
            {
               
                string path1 = "TextFile1.txt";
                streamReader1 = new StreamReader(path1);
                Console.WriteLine(streamReader1.ReadToEnd());
                string path = "C:\\FileExcpetion\\sampl.txt";
                streamReader = new StreamReader(path);
                Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader1?.Close();
                streamReader?.Close();
            }
        }
    }
}