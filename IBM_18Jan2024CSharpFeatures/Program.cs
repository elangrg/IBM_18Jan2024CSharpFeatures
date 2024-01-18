using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class Program
    {
        public static void Main()
        {

            //int? k = null;

            //Nullable<Int32> l = null;
            //if (k.HasValue)
            //{
            //    Console.WriteLine(k.Value);
            //}


            int i = 100;
            Console.WriteLine("Before Display  i={0} ", i);
            display(i);
            Console.WriteLine("After Display i={0} ", i);

            displayRef(ref i);
            Console.WriteLine("After DisplayRef i={0} ", i);

            displayOut(out i);
            Console.WriteLine("After DisplayOut i={0} ", i);

            displayParams(10, 20, 30, 40);

            int[] arr = { 1, 2, 3, 4, 5 };

            int[] arr1 = new int[2];

            int[,,] arr2= new int[2,2,2];

            displayParams(arr);
            displayParams();

            Console.WriteLine(add(100, 200));
            Console.WriteLine(add(100, 200, 500));
            Console.WriteLine(add(b: 100, d: 200, a: 100));
        }

        static void display(int x)
        {
            x++;
            Console.WriteLine(" In Display x={0} ", x);
        }


        static void displayRef(ref int x)
        {
            x++;
            Console.WriteLine(" In DisplayRef x={0} ", x);
        }

        static void displayOut(out int x)
        {

            x = 0;
            x++;
            Console.WriteLine(" In DisplayOut x={0} ", x);
        }

        static void displayParams(params int[] x)
        {
            int j = 0;
            if (x.Length == 0)
                Console.WriteLine("No Values in X[] ");
            else if (x.Length > 0)
                for (j = 0; j < x.Length; j++)
                    Console.WriteLine(" In Display Params-> x[{0}]={1} ", j, x[j]);
        }



        static int add(int a, int b, int c = 100, int d = 200)
        {

            return a + b + c+d;

        }
    }

}

