using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterInterface
{
    internal class ProcessInput
    {
        IPrinter _printer;
        public ProcessInput( IPrinter printer) {
            _printer = printer;
        }

        public void PrintData()
        {
            _printer.Print();
        }
    }
}
