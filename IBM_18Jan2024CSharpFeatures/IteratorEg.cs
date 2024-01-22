using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class IteratorEg
    {

        static void Main()
        { 
            MSEmployee obj=new MSEmployee();
            foreach (string item in obj)
            {
                Console.WriteLine(item);
                
            }

            Console.ReadKey(  );
        }


    }


    class MSEmployee:IEnumerable
    {
        List<string> _lstSkills= new List<string> { "Coding","Testing" };

        public IEnumerator GetEnumerator()
        {
            return new StringEnumerator(_lstSkills);

        }
    }

    class StringEnumerator : IEnumerator
    {

        List<string> _data;
        int _idx = -1;


        public StringEnumerator(List<string> data)
        {
            _data = data;  
        }

       // public object Current => _data[_idx];
        public object Current { get { 
                return _data[_idx]; } } 
        public bool MoveNext()
        {
            _idx++;

            if (_idx > _data.Count-1) { return false; }
            return true;
        }

        public void Reset()
        {
            _idx =-1;
        }
    }

}
