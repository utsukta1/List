using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayL
{
    internal class Arrayll
    {
        public void ArrayListt()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(99999);
            arrayList.Add(1);
            //Console.WriteLine("count : " + arrayList.Count);
            //Console.WriteLine("Capacity: " + arrayList.Capacity);
            //arrayList.Add("BYE!");
            //Console.WriteLine("count : " + arrayList.Count);
            //Console.WriteLine("Capacity: " + arrayList.Capacity);
            //arrayList.Add("Bye!");
            //arrayList.Add("OK");
            //Console.WriteLine("count : " + arrayList.Count);
            //Console.WriteLine("Capacity: " + arrayList.Capacity);

            //Console.WriteLine(arrayList.IsFixedSize);
            //Console.WriteLine(arrayList.IsReadOnly);

            arrayList.AddRange(new ArrayList() {4, 181247, 3});

            //arrayList.Insert(0, "First value at index 0");
            //arrayList.Insert(2, " value at index 2");
            //arrayList.Remove("Utsukta");
            //arrayList.RemoveRange(0, 3);
            //arrayList.RemoveAt(2);
            //arrayList.Reverse();
            // Console.WriteLine(arrayList.Contains(181247));
            arrayList[1] = 54;
            

            for(int i=0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }




        }
    }
}
