using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Area_Inheritence
{
    internal class Rectangle
    {
        public double length;
        public double breadth;


        public double CalculateArea(double length,double breadth)
        {
            double result = length * breadth;
            return result;
        }
    }
}
