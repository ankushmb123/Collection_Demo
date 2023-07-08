using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    //Its a Generic Collection it will store key valye paire
    //Define under system.Collections.namespace
    //It is dynamic in nature
    //In the dictionary the key can't be null but value can be null
    //The Key must be unique to duplicate a key are not allowed
    //we can store only same Data type of value

    public class Dictionary_Demo
    {
        public void Diction()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("1", "Ankush");
            keyValuePairs.Add("2", "car");
            keyValuePairs.Add("3", "Maruti");
            keyValuePairs.Add("4", "Ford");

            Console.WriteLine(keyValuePairs["3"]);
            keyValuePairs["2"] = "Audi";
            Console.WriteLine(keyValuePairs["2"]);
            Console.WriteLine("------------------------");

            keyValuePairs.Remove("2");
            keyValuePairs.Clear();

            foreach (KeyValuePair<string, string> ele in keyValuePairs)
            {
                Console.WriteLine(ele.Key + ":" + ele.Value);
            }

            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var item = keyValuePairs.ElementAt(i);
                Console.WriteLine(item.Value);
            }
        }

    }
}
