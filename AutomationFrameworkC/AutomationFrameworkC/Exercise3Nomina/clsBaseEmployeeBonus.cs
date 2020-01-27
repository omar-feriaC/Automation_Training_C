using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3Nomina
{

    //We are going to inhereit from clsEmployee
    /*
     * We already have an specific method
     * We need to add 20% to his total Salary
     * */

    class clsBaseEmployeeBonus : clsEmployee
    {
        //ATTRIBUTES
        public double dbBonusForEmployee { get; set; }

        //CONSTRUCTOR
        public clsBaseEmployeeBonus(){}
    }
}
