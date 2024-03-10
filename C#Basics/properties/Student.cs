using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Student
    {
        private int id;
        private string name;
        private int passMark = 40;

        public int Id
        {
            get { return id; } set { id = value; }
        }
        public int PassMark { get {  return passMark; } set {  passMark = value; } }

        public string Name
        { set { 
                if(!string.IsNullOrEmpty(value))
                {
                    if(!value.StartsWith("p"))
                    {
                        throw new Exception("Name should start with p");
                    }
                    name = value;
                }
                else
                {
                    throw new Exception("Name cannot be null or empty");
                }
                
                 }
        }

    }
}
