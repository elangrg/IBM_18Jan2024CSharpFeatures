using IBM_18Jan2024CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class GenericEg
    {

        public static void Main()
        {
            Console.WriteLine( Min<int>(100,200) );
            Console.WriteLine(Min(1.10, 0.12));
            Console.WriteLine(Min("abc", "xyz"));
            Console.WriteLine(Min<string>("200", "500"));


            GenSyntaxEg<Employee, Employee, IBMEmployee>(new Employee(), new Employee());


        }

        //static int Min(int a, int b)
        //{ 
        //if (a < b) 
        //     return a; 
        //else
        //     return b;
        //}

        //static double  Min(double a, double b)
        //{
        //    if (a < b)
        //        return a;
        //    else
        //        return b;
        //}

        //static IComparable Min(IComparable a, IComparable b)
        //{
        //    if (a.CompareTo(b)<0)
        //        return a;
        //    else
        //        return b;
        //}

        static T Min<T>(T a, T b) where T:IComparable<T>    
        {
            
            if (a.CompareTo(b) < 0)
                return a;
            else
                return b;
        }


        static TReturn GenSyntaxEg<T1,T2,TReturn>(T1 a, T2 b) 
            where T1 : Employee
            where T2 : Employee
                  where TReturn : class,new()



        {
            TReturn obj =new  TReturn();


            return obj;


        }
    }


    class GenericEgClass<T>
    {

        public GenericEgClass()
        {
            T a= default (T);   
                
        }

    }

}
