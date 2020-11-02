using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car:Parts
    {
        static void main()
        {
            Car C = new Car();
            C.wheel = 4;
            C.engine = "v6";
            C.DisplayParts();

        }


    }
}
