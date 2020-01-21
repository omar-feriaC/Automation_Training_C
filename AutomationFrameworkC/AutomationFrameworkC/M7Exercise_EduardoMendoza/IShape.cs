using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_EduardoMendoza
{
    interface IShape
    {
        //Attributes
        string strName { get; set; }
        double dblArea { get; set; }
        double dblPerimeter { get; set; }

        //Methods
        void fnDisplayInfo();
    }
}
