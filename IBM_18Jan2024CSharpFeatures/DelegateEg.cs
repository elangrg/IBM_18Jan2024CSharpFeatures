using System;
using System.Collections;

using System.Collections.Generic; // 2.0
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    delegate int DlgDemo(int a, int b);
    delegate void Dlgdisplay(string msg);
    internal class DelegateEg
    {
        public static void Main()
        {
            // 1.0 syntax
            DlgDemo fptr = new DlgDemo(Add);

            // 2.0 
            // DlgDemo fptr = Add;
            fptr += Multi;
            // anonymous block / method
            fptr += delegate (int x, int y) { return x + y; };

            // 3.0 
            fptr += (int x,int y)=> { return x + y; };

            fptr += ( x,  y) => { return x + y; };

            fptr += (x, y) => x + y; 

            Dlgdisplay  d= a=>Console.WriteLine(a);

            Console.WriteLine(fptr(100, 200)  ); 



            Func<int,int,int> func = (x, y) => x + y;

            func(100,200);

            Action<string,string> fullname =(fn,ln)  => 
            Console.WriteLine(  fn + " "  + ln);



        }
        static int Add(int i, int j)
        {
            return i + j;
        }

        static int Multi(int i, int j)
        {
            return i * j;
        }


    }
}
