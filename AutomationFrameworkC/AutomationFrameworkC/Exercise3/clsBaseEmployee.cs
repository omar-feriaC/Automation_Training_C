using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3
{
    class clsBaseEmployee : clsEmployee
    {
        //Attributes
        public double dblBasePercentage { get; set; }
        public int intDaysWorked { get; set; }

        //Constructor
        public clsBaseEmployee(){}

        public clsBaseEmployee(string pstrID, string pstrPosition, string pstrExperience, double pdblSalary, double pdblBasePercentage, int pintDaysWorked)
        {
            strID = pstrID;
            strPosition = pstrPosition;
            strExperience = pstrExperience;
            dblSalary = pdblSalary;
            dblBasePercentage = pdblBasePercentage;
            intDaysWorked = pintDaysWorked;
        }

        //Methods
        public double fnCalculateSalary()
        {
            dblSalaryTotal = ((dblBasePercentage + 1) * dblSalary) * (intDaysWorked);
            return dblSalaryTotal;
        }

    }
}
