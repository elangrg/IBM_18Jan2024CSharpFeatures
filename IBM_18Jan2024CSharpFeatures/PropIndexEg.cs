
using IBM_18Jan2024CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class PropIndexEg
    {

        public static void Exec()
        {
            Employee obj = new Employee();
            obj.EmpID = 1000;
            obj.EmpName= "Ganesh";

            obj.DOB = DateTime.Now.AddDays(-100000);

            obj.Salary = 1000;

            obj[2] = "Designer";

            Console.WriteLine( $"Value in EmpID:{obj.EmpID}, Emp Name:{obj.EmpName} , Age:{obj.Age}, Salary:{obj.Salary} , Primary Skill:{obj[0]}");
        }



    }
}
