using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise
{
    interface IShape
    {
        double dblArea { get; set; }
        double dblVolume { get; set; }
        double dblPerimeter { get; set; }
        string strName { get; set; }
        void DisplayInfo();
    }
}
