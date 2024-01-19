using System;

namespace IBM_18Jan2024CSharpFeatures.Models
{
    internal interface IEmployee
    {
        string this[int index, string st = ""] { get; set; }

        string Address { get; set; }
        int Age { get; }
        DateTime DOB { get; set; }
        int EmpID { get; set; }
        string EmpName { get; set; }
        double Salary { get; set; }

        string ToString();
    }
}