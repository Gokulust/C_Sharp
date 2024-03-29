﻿namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessDataFile accessDataFile = new AdminDataFileUser();
            accessDataFile.FilePath = @"c:\temp\a.txt";
            accessDataFile.ReadFile();
           accessDataFile.WriteFile();

            AccessDataFile accessDataFileR = new RegularDataFileUser();
            accessDataFileR.FilePath = @"c:\temp\a.txt";
            accessDataFileR.ReadFile();
            accessDataFileR.WriteFile();

        }
    }
    public class AccessDataFile
    {
        public string FilePath { get; set; }
        public virtual void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"Base File {FilePath} has been read accessDataFile");
        }
        public virtual void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"Base File {FilePath} has been written AccessDatafile");
        }
    }

    public class AdminDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"File {FilePath} has been written");
        }
    }


    public class RegularDataFileUser:AccessDataFile
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            throw new NotImplementedException();
        }
    }

}