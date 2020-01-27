using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3Nomina
{
    class clsEmployee : IPerson
    {
        //ATRIBUTES
        public string strID { get; set; }
        public string strPosition { get; set; }
        public string strExperience { get; set; }
        public double dblSalary { get; set; }

        //attribute specific of employee
        public double dblSalaryTotal { get; set; }

        //CONSTRUCTOR / CONSTRUCTORES

        public clsEmployee()
        {
            strID = "";
            strPosition = "";
            strExperience = "";
            dblSalary = 0.0;
            dblSalaryTotal = 0.0;
        }


        //since we are going to calculate the SALARYTOTAL we are goint to use a constructor without the dblSalaryTotal
        public clsEmployee(string pstrID, string pstrPosition, string pstrExperience, double pdblSalary)
        {
            strID = pstrID;
            strPosition = pstrPosition;
            strExperience = pstrExperience;
            dblSalary = pdblSalary;
            
        }



        //METHODS
        // -- public is a modificador de acceso
        public void fnGetInfo()
        {
            Console.WriteLine("Display Employee Info: ");
            Console.WriteLine("strID: " + strID);
            Console.WriteLine("strPosition: " + strPosition);
            //otherways to do
            //Console.WriteLine("strPosition: {0}", strPosition);
            //Console.WriteLine("strPosition: {0} {1} {2}", strPosition, strPosition, strPosition);
            //Console.WriteLine($"strPosition: {strPosition}");

            Console.WriteLine("strExperience: " + strExperience);
            Console.WriteLine("dblSalary: " + dblSalary);

        }
        //all methods that are not void, must have a return
        public double fnGetSalary()
        {
            return dblSalaryTotal;
        }
    }
}
