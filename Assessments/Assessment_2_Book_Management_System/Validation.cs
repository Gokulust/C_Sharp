using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Book_Management_System
{
    internal class Validation
    {
        public static void ValidString(string title,string type)
        {
            if(string.IsNullOrWhiteSpace(title)) {
                throw new CustomException($"{type} Cannot be null or empty");
            }
        }
        public static void ValidDouble(string value,string type)
        {
            ValidString(value,type);
            double result;
            if(!double.TryParse(value, out result))
            {
                throw new CustomException($"Invalid {type}");
                
            }
            else
            {
                if(type=="Rating")
                {
                    if (!(result>=0 && result <=5))
                    {
                        throw new CustomException($"{type} must be 0 to 5");
                    }
                   
                }
                if(type=="Price")
                {
                    if(result<0)
                    {
                        throw new CustomException($"{type} cannot be negative");
                    }
                }
                
            }
        }
    }
}
