using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise
{
    interface ICar
    {
        //Attributes
        string strEngine { get; set; }
        string strTires { get; set; }
        string strColor { get; set; }
        string strModel { get; set; }
        

        //Methods
        void fnStart();
        void fnBrake();
        void fnParking();
        void fnCalculateKM();

    }
}
