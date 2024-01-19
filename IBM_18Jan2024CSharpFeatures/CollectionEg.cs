using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class CollectionEg
    {
        static void Main()
        { 
            
            List<string> list = new List<string>();

            list.Add("Ganesh");
            list.Add("Mahesh");
            list.Add("Ramesh");
            list.Add("Suresh");


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(0);
            list.Remove("Suresh");

            Console.WriteLine( list[1] ); 

            Dictionary<string,string> Emps = new Dictionary<string,string>();
            Emps.Add("10001", "Ganesh");
            Emps.Add("10002", "Mahesh");

            Console.WriteLine(Emps["10001"]);

            foreach (KeyValuePair<string, string> item in Emps) {

                Console.WriteLine(  item.Value +  item.Key);
            }

        }
    }
}
