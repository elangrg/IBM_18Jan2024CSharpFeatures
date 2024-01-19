using IBM_18Jan2024CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class CtorEg
    {

        public static void Exec()
        { 
        
            Employee employee = new Employee("Ganesh",1010,"Blr");

            Console.WriteLine( clsStaticCtorEg.obj.Address );

            singleton obj =  singleton.GetObject();

        }


    }
}
