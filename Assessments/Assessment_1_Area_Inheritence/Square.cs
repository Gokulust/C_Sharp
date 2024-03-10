using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Area_Inheritence
{
    internal class Square : Rectangle
    {
       
       public double CalculateArea(double length)
        {
            double result = length * length;
            return result;
        }
    }
}
