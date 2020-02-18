using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise
{
    class _2DShape : IShape
    {
        //Attributes 
        public double dblArea { get; set; }
        public double dblVolume { get; set; }
        public string strName { get; set; }
        public double dblPerimeter { get; set; }
        
        //Constructor
        public _2DShape()
        {
            strName = "undefined";
            dblArea = 0;
            dblPerimeter = 0;
        }

        //Methods
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
        }
    }
}
