using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface INormalCalculator
    {
        // int c=10;
        // Interface cannot have
        int Add(int a, int b);
        string CalcName();
    }
    class Computing : INormalCalculator,IScientificCalculator
    {
        internal string Getname()
        {
            return "Computing";
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        string INormalCalculator.CalcName()
        {
            return "INormalCalculator";
        }
        string IScientificCalculator.CalcName()
        {
            return "IScientificCalculator";
        }

        
    }
    class InterfaceEg
    {
        static void Main()
        {
            Computing computing = new Computing();
            Console.WriteLine("Addition:{0}", computing.Add(45,99));
            Console.WriteLine("Class:{0}", computing.Getname());
            INormalCalculator N = new Computing();
            Console.WriteLine(N.CalcName());
            IScientificCalculator S = new Computing();
            Console.WriteLine(S.CalcName());
            Console.Read();
               
        }
    }
}
