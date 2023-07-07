using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    public class Program
    {
        //Collection is a class that means we can create an object
        //can be create or declared instance of a class ,so we can add a data in collections
        //collection types - are designed to store ,manage similar data
        //We can used to adding ,remove,find and sorting data in collection
        //two types - Generic and Non-Generic collections
        //Non-generic - arrayList , Hashtable, sortedlist, stack and Queue
        //Generic - List ,dictionary,Sortedlist,stack and queue
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-List");
                Console.WriteLine("2-Array");
                Console.WriteLine("------------------------");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------------------");
                        List_Demo list_Demo = new List_Demo();
                        list_Demo.Adding();
                        break;
                    case 2:
                        Console.WriteLine("----------------------");
                        Array_Demo array_Demo = new Array_Demo();
                        array_Demo.Add();
                        break;
                }
            }
        }
    }
}