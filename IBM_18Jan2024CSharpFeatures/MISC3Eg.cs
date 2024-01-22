using IBM_18Jan2024CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class MISC3Eg
    {
      

        static void Main()
        { 
        Product prd= new Product ();


            int? i = null;

        Nullable<int> n = null;


            if (i.HasValue) {

                Console.WriteLine(  i.Value);
            }



           // LTIAnonTypeObjectInit();

            char ch= 'A';
            ExtensionMethodEg.IsValidEmpIDChar(ch);
            ch.IsValidEmpIDChar();

            string st = "";
            st.IsValidEmpIDChar();


            Employee employee = new Employee ();
            employee.IsValidEmpIDChar();



        }

        static void LTIAnonTypeObjectInit() {

            #region LTI
            int i = 100;
            var j = 100;
            //var l;

            //var k = null;

            var k = default(int); 
            #endregion

            Employee obj = new Employee { Address="blr", Salary=12345 };

            var obj1 = new Employee { Address="blr", Salary=12345 };

            var obj2 = new  { Address = "blr", Salary = 12345 };
            var obj3 = new { Address = "Kol", Salary = 423432 };

            var obj4 = new {Salary = 423432, Address = "Kol"  };


            Console.WriteLine( obj1.GetType());
            Console.WriteLine(obj2.GetType());
            Console.WriteLine(obj3.GetType());
            Console.WriteLine(obj4.GetType());

            Console.WriteLine( 1000);





        }


    }


    static class ExtensionMethodEg
    {
        public static bool IsValidEmpIDChar(this object c, string st="") { return true; }

    }
static class ExtensionMethodEg1
    {
        public static bool IsValidEmpIDChar2(this char c, string st="") { return true; }

    }

}
