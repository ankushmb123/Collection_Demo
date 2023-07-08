using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    //Its a non-generic Collection
    //It is same as array e
    public class Array_List
    {
        public void MyArray()
        { 
        ArrayList arrayList = new ArrayList();  
            arrayList.Add(11);
            arrayList.Add("Ankush");
            arrayList.Add('a');
            arrayList.Insert(0, 20);
            arrayList.Insert(2, "Car");
            arrayList.Insert(4, 'b');

            arrayList.Remove('a');
           // arrayList.RemoveAt(7);
            Console.WriteLine(arrayList);


            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Insert(0, 20);

            for(var i=0; i<arrayList.Count; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
