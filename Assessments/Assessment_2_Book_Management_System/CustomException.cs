using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Book_Management_System
{
    internal class CustomException:Exception
    {
        public CustomException(string message):base(message) { }
    }
}
