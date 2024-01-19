using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures.Models
{
    class Employee : IEmployee
    {
        public Employee()
        {
            _EmpID = 1000;
            EmpName = "Ganesh";
            Salary = 10000;
            DOB = DateTime.Now;
        }

        public Employee(string EmpName, int empid)//:this()
        {
            this.EmpName = EmpName;
            this.EmpID = empid;

        }
        public Employee(string empName, int empid,
            string Address) : this(empName, empid)
        {

            this.Address = Address;
        }


        private int _EmpID;
        // 1.0
        public int EmpID
        {
            get
            {
                return _EmpID;
            }
            set
            {
                _EmpID = value;
            }
        }

        //3.0 auto prop 
        public string EmpName { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;

        string[] Skills = { "Programming", "Testing", "..." };


        public int Age
        {
            get { return DateTime.Now.Year - DOB.Year; }

        }

        private double _Salary;

        public double Salary
        {
            get { return _Salary; }
            set
            {
                if (value < 10000) { _Salary = 10000; return; }


                _Salary = value;
            }
        }

        public string Address { get; set; }

        public string this[int index, string st = ""]
        {
            get { return Skills[index]; }
            set { Skills[index] = value; }

        }


        public override string ToString()
        {
            return $"Value in EmpID:{this.EmpID}, Emp Name:{EmpName} , Age:{Age}, Salary:{Salary}";
        }

    }


    class IBMEmployee:Employee
	{
        public IBMEmployee():base("",100)
        {
				
        }
    }




	static class clsStaticEg
	{
		static string st = "";

        static  clsStaticEg()
        {
		
        }


        public static  void Display()
		{
            Console.WriteLine(	"Display called");
        }

	}


     class clsStaticCtorEg
    {
			public 	static Employee obj;

        static  clsStaticCtorEg()
        {
			obj = new Employee();

        }

        public static void Display()
        {
            Console.WriteLine("Display called");
        }

    }


	class singleton
	{

		static singleton _obj=null;

		public static singleton GetObject()
		{
			if (_obj == null) _obj=new singleton();

			return _obj;
		}

        private singleton()
        {
				
        }

    }


}
