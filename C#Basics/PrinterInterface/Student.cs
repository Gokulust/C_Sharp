using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterInterface
{
    internal class Student : IPrinter
    {
        int id=1;
        string name="gokul";
        public void Print()
        {
            Console.WriteLine($" Student id and name are :{id},{name}");
        }
    }
}
