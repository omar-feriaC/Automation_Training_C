using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3
{
    class clsEmployee : IPerson
    {
        //Attributes
        public string strID { get; set; }
        public string strPosition { get; set; }
        public string strExperience { get; set; }
        public double dblSalary { get; set; }
        public double dblSalaryTotal { get; set; }

        //Constructor
        public clsEmployee()
        {
            strID = "";
            strPosition = "";
            strExperience = "";
            dblSalary = 0.0;
            dblSalaryTotal = 0.0;
        }

        public clsEmployee(string pstrID, string pstrPosition, string pstrExperience, double pdblSalary)
        {
            strID = pstrID;
            strPosition = pstrPosition;
            strExperience = pstrExperience;
            dblSalary = pdblSalary;
        }

        public clsEmployee(double pdblSalary)
        {
            strID = "";
            strPosition = "";
            strExperience = "";
            dblSalary = pdblSalary;
            dblSalaryTotal = 0.0;
        }

        //Methods
        public void fnGetInfo()
        {
            Console.WriteLine("Display Employee Info:");
            Console.WriteLine("strID: " + strID);
            Console.WriteLine("strPosition: " + strPosition);
            Console.WriteLine("strExperience: " + strExperience);
            Console.WriteLine("dblSalary: " + dblSalary);
            Console.WriteLine("dblSalaryTotal: " + dblSalaryTotal);
            //Console.WriteLine("strPosition: {0} {1} {2}", strPosition, strPosition, strPosition);
            //Console.WriteLine($"strPosition: {strPosition}");
        }

        public double fnGetSalary()
        {
            return dblSalaryTotal;
        }
    }
}
