using IBM_18Jan2024CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class InterfaceEg
    {

        public static void Exec()
        {

            IEmployee objEmp= new  Employee();

            objEmp.Address = "";

            Product  objProduct= new Product();

            objProduct.ProductName = "BMW";
            Console.WriteLine(objProduct.ProductName);


            IProduct obj = objProduct;
            Console.WriteLine( obj.ProductName ); 

        }




    }
}
