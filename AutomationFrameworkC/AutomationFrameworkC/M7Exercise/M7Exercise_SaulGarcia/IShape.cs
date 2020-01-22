using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia
{
    interface IShape
    {
        //Attributes
        double dblArea { get; set; }
        double dblPerimeter { get; set; }
        double dblVolume { get; set; }
        string strName { get; set; }
        double dblBaseArea { get; set; }

        //Methods
        void fnDisplayInfo();
        void fnGetArea();
        void fnGetPerimeter();
        void fnGetVolume();
        void fnGetBaseArea();

    }
}
