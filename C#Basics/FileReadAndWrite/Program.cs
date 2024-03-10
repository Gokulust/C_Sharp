namespace FileReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "textfile.txt";
            string Text = "First Method\nWriteAllText(path,text) and ReadAllText(path)";
            File.WriteAllText(path, Text);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            string Text2 = "Second Method: StreamWriter and StreamReader";
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text2);
            }
            
            using (StreamReader readtext = new StreamReader(path))
            {
                string read2 = readtext.ReadLine();
                Console.WriteLine(read2);
            }
            string[] text3 = { "Writing using WriteAllLines and reading using ReadAllLines \n hello" };
            File.WriteAllLines(path, text3);
            string[] read3 = File.ReadAllLines(path);
            foreach (string read in read3)
            {
                Console.WriteLine(read[0]);
                Console.WriteLine(read);
            }

        }
    }
}