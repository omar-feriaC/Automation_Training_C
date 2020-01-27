using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3Nomina
{
    interface IPerson
    {
        //ATRIBUTES
        string strID { get; set; }
        string strPosition { get; set; }
        string strExperience { get; set; }
        double dblSalary { get; set; }

        //METHODS
        void fnGetInfo();
        double fnGetSalary();

        
    }
}
