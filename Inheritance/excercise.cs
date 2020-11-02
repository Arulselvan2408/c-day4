using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AICTE
    {
        protected string Standard= "AICTE Standard";
    }
    class AnnaUniversity:AICTE
    {
        internal int CollegeNO=101;
        internal int TotalSeats=2500;
        internal void DisplayAnna()
        {
            Console.WriteLine("CollegeNO:{0}\nTotalSeats:{1}\nStandard:{2}", CollegeNO, TotalSeats, Standard);
        }
    }
    class MumbaiUniversity:AICTE
    {
       internal int CollegeNO = 102;
       internal int TotalSeats = 2000;
       internal void DisplayMumbai()
        {
            Console.WriteLine("CollegeNO:{0}\nTotalSeats:{1}\nStandard:{2}", CollegeNO, TotalSeats, Standard);
        }
       
    }

    class excercise
    {
        static void Main()
        {
            MumbaiUniversity Muniversity = new MumbaiUniversity();
            Muniversity.DisplayMumbai();
            AnnaUniversity Auniversity = new AnnaUniversity();
            Auniversity.DisplayAnna();
            Console.Read();
        }
    }
}
