using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise
{
    class _3DShape : _2DShape, IShape
    {
        //Attributes
        public new double dblVolume { get; set; }
        public new string strName { get; set; }
        public new double dblArea { get; set; }

    //Constructor
    public _3DShape()
        {
            strName = "Undefined";
            dblVolume = 0;
            dblArea = 0;
        }

        //Methods
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Volume: " + dblVolume);
        }
}
}
