using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise3
{
    interface IPerson
    {
        //Attributes
        string strID { get; set; }
        string strPosition { get; set; }
        string strExperience { get; set; }
        double dblSalary { get; set; }

        //Methods
        void fnGetInfo();
        double fnGetSalary();
    }
}
