using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface Icar
    {
        string Brake();
        string Engine();
        
    }
    class Benz:Icar
    {
        string Icar.Brake()
        {
            return "BenzBrake";
        }

        string Icar.Engine()
        {
            return "BenzEngine";
        }
    }
    class Toyoto : Icar
    {
        string Icar.Brake()
        {
            return "ToyotoBrake";
        }

        string Icar.Engine()
        {
            return "ToyotoEngine";
        }

    }
    class Maruthi: Icar
    {
        string Icar.Brake()
        {
            return "MaruthiBrake";
        }

        string Icar.Engine()
        {
            return "MaruthiEngine";
        }
    }
    class ICar
    {
        static void Main()
        {
            Icar B = new Benz();
            Console.WriteLine(B.Brake());
            Console.WriteLine(B.Engine());
            Icar T = new Toyoto();
            Console.WriteLine(T.Brake());
            Console.WriteLine(T.Engine());
            Icar M = new Maruthi();
            Console.WriteLine(M.Brake());
            Console.WriteLine(M.Engine());
            Console.Read();
        }

    }
       
}
