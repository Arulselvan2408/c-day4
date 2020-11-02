using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{class Organization
    {
        protected string OrgName= "LTI";
        protected string location;
        internal void DisplayOrg()
        {
            Console.WriteLine("OrgName: {0}\nLocation: {1}", OrgName, location);

        }

    }
    
    //Inheritance
    class Employee:Organization
    {
        int Eid = 1001;
        float salaryperhr = 2500.79f;
        internal void DisplayEmployee()
        {
            Console.WriteLine("Eid{0}\nSalart:{1}\nOrgName:{2}\nlocation:{3}", Eid, salaryperhr, OrgName, location);
        }
        static void Main()
        {
            // Organization organization = new Organization();
            //Organization.DisplayOrg();
            Employee employee = new Employee();
            //acess parent class information through child class object
            employee.location = "chennai";
            employee.DisplayOrg();
            employee.DisplayEmployee();
            Console.Read();

        }
    }
    
    class SingleInheritance
    {
       
    }
}
