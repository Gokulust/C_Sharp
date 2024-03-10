using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWithSameFunctions
{
    internal class InterfaceClass : Interface2
    {
         void Interface2.Print()
        {
            Console.WriteLine("Interface2 Print method");
        }

         void Interface1.Print()
        {
            Console.WriteLine("Interface1 Print method");
        }
    }
}
