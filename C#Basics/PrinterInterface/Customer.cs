using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterInterface
{
    internal class Customer:IPrinter
    {
        int id=2;
        string name="anlin";

        public void Print()
        {
            Console.WriteLine($" Customer id and name are :{id},{name}");
        }
    }
}
