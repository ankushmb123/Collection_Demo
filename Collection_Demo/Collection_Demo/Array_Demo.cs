using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    //Array is a collection  of elements  of same data type
    //Array index start with 0
    //we can store only fix set of element in array
    public class Array_Demo
    {
        public void Add()
        {
            //int[] myArray = { 1, 2, 3, 4, 5 };
            //int[] myArray_Two = new int[5];
            // int[] myArray_Three[] 
            int[] myArray = new int[10];
            string[] strings = new string[10];

            int[] obj = new int[] { 1, 2, 3 };
            int[] ints = { 1, 2, 3, 4, 5, 6 };

            string[] strings_One = new string[4] { "Ankush", "Anish", "Ravi", "Ketan" };
            foreach (string ele in strings_One)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("---------------------");
            for (int val = 0; val < strings_One.Length; val++)
            {
                Console.WriteLine(strings_One[val]);
            }
            Console.WriteLine("---------------------");

            int value = 0;
            while (value < strings_One.Length)
            {
                Console.WriteLine(strings_One[value]);
                value++;
            }
            string[] strings_Two = new string[] { "Ankush", "Anish", "Ravi", "Ketan" };
        }
    }
}