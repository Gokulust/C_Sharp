using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Customer:IInterfaceCustomer,ICustomer3,ICustomer4
    {
        public void LogData(string message) {
            Console.WriteLine("Logdata message");
        }
        public void Print() { Console.WriteLine("message printed");}

        public void Display(string message) { Console.WriteLine(); }

        void IInterfaceCustomer.Method2()
        {
            Console.WriteLine("IInterfaceCustomer Method2");
        }

        void ICustomer2.Method2() { Console.WriteLine("Customer Method2"); }
       
        public void Method3() { Console.WriteLine("Method 3"); }

        void ICustomer3.Method2() { Console.WriteLine("customer3 Method2"); }

        void ICustomer4.Method2() { Console.WriteLine("customer4 method4"); }
        public void Method2()
        {
            Console.WriteLine("Method 2 !!!");
        }
    }
}
