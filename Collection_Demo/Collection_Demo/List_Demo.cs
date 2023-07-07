using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    //List<T> class represents the list of objects which can be accessed with index
    //List is Dynamic ,we can resize the list
    public class List_Demo
    {
        //Creating a list of integers
        List<int> list = new List<int>();
        public void Adding()
        {
            list.Add(12);
            list.Add(30);
            list.Add(10);
            list.Add(5);
            list.Add(19);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List - " + list.Count);
            Console.WriteLine("Capacity of List - " + list.Capacity);

            list.Add(45);
            list.Add(36);
            list.Add(7);
            list.Add(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List - " + list.Count);

            Console.WriteLine("Capacity of List - " + list.Capacity);
            Console.WriteLine("Find Element " + list.Contains(1));
            Console.WriteLine("Remove Element " + list.Remove(14));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Removing Element in a Particular position");
            list.RemoveAt(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Reversing the order of list");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Sorting the List");
            list.Add(2);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Deleting the Complete list");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}