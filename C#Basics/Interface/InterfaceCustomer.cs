using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IInterfaceCustomer:ICustomer2
    {
        void LogData(string message);
        new void  Method2();
        void Print();
    }
}
