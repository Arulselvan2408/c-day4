using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class RBI
    {
        int empno = 20;
        public abstract int HomeLoan();
        public abstract int EducationLoan();

        //non abstract method
        internal void RBIEmployeee()
        {
            Console.WriteLine("RBI  employeee deatis:{0}", empno);
        }
    }
    class SBI : RBI
    {
        public override int HomeLoan()
        {
            return 9;
        }
        public override int EducationLoan()
        {
            return 10;
        }

    }
    class HDFC : RBI
    {
        public override int HomeLoan()
        {
            return 10;
        }
        public override int EducationLoan()
        {
            return 11;
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            /*SBI sbi = new SBI();
            Console.WriteLine("SBI H Loan:{0}", sbi.HomeLoan());
            Console.WriteLine("SBI E Loan:{0}", sbi.EducationLoan());
            HDFC hdfc = new HDFC();
            Console.WriteLine("HDFC H Loan:{0}", sbi.HomeLoan());
            Console.WriteLine("HDFC E Loan:{0}", sbi.EducationLoan());
            Console.Read();*/
            //run time ploymorphism
            RBI r;
            r = new SBI();
            r.RBIEmployeee();
            Console.WriteLine("sbi h loan:{0}", r.HomeLoan());
            Console.WriteLine("sbi e loan:{0}", r.EducationLoan());
            r = new HDFC();
            Console.WriteLine("hdfc h loan:{0}", r.HomeLoan());
            Console.WriteLine("hdfc e loan:{0}", r.EducationLoan());
            Console.Read();
        }
    }
}
