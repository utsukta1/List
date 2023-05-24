using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayL
{
    internal class Salesmen
    {
        public string Name { get; set; }

        public string City { get; set; }
        public int Age { get; set; }
        public Salesmen(string name, string city, int age) 
        {
            Name = name;
            City = city;
            Age = age;
        }
        
        
    }
}
