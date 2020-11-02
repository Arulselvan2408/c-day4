using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class College
    {
        protected string id = "C101";
        //protected string collegeName = "UPES";
        protected string collegeName;
        internal College(string collegeName)
        {
            this.collegeName = collegeName;
            Console.WriteLine("College Constructor");
        }
        ~College()
        {
            Console.WriteLine("college destructor");
        }
    }
    class Deptname:College
    {
        protected String Dname;
        protected string id = "d1000";
        internal Deptname(string Cname,String Dname):base(Cname)
        {
            this.Dname = Dname;
            Console.WriteLine("Dpartment Constuctor");
        }
        //protected string DeptName = "Upstream";

        protected void Getdept()
        {
            Console.WriteLine("collegeid:{0}||Deptid:{1}", base.id, id);
            Console.WriteLine("collegename:{0}\ndeptName:{1}", collegeName, Dname);
        }
        ~Deptname()
        {
            Console.WriteLine("Dept Destructor");
        }
    }
    
    class Student:Deptname
    {
        //string Stuname = "Arul";
        string Stuname;
        Student(string Cname, string Dname, string Stuname):base(Cname,Dname)
        {
            this.Stuname = Stuname;
            Console.WriteLine("student Constuctor");
        }
     void DisplayStuInfo()
        {
            Console.WriteLine("collegename:{0}\ndeptName:{1}\nstuName:{2}\n", collegeName, Dname, Stuname);
        }
        static void Main()
        {
            Student student = new Student("UPES", "Upstream", "Arul");
            student.Getdept();
            student.DisplayStuInfo();
            GC.Collect();
            Console.Read();
        }
        ~Student()
        {
            Console.WriteLine("Student Destructor");
        }
    }
    class MultileveInheritance
    {
    }
}
