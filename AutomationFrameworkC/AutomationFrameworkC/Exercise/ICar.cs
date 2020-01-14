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
        string engine { get; set; }
        string tires { get; set; }
        string color { get; set; }
        string model { get; set; }
        string plate { get; set; }

        //Methods
        void fnStart();
        void fnBrake();
        void fnParking();
        void fnCalculateKM();

    }
}
