using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayL
{
    internal class Diction
    {
        public void Dictionary1()
        {
            IDictionary<string,int> nameRoll = new Dictionary<string,int>();
            nameRoll.Add("Utsukta", 181247);
            nameRoll.Add("Fereeca", 181214);
            foreach (KeyValuePair<string,int> kvp in nameRoll) 
            {
                Console.WriteLine("Key: {0} , Value : {1}" , kvp.Key, kvp.Value);
            }

        }
    }
}
