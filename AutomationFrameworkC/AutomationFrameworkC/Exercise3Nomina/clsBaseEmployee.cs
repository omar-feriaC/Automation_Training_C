using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3Nomina
{
    class clsBaseEmployee : clsEmployee
    {
        //ATTRIBUTES
        public double dblBasePercentage { get; set; }
        public int intDaysWorked { get; set; }

        //CONSTRUCTOR
        public clsBaseEmployee ()
        {
        }

        public clsBaseEmployee(double pdblBasePercentage, int pintDaysWorked)
        {
            dblBasePercentage = pdblBasePercentage;
            intDaysWorked = pintDaysWorked;
        }

        //METHODS

        public double fnCalculateSalary()
        {
            dblSalaryTotal = ((dblBasePercentage + 1) * dblSalary) * (intDaysWorked);
            return dblSalaryTotal;
        }

    }
}
