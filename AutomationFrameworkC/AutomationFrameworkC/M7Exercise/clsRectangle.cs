using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise
{
    class clsRectangle : cls2D_Shape
    {
        //Attributes
        public double dblWidth { get; set; }
        public double dblHeight { get; set; }

        //Constuctor
        public clsRectangle() { }
        public clsRectangle(string pstrName, double pdblWidth, double pdblHeight)
        {
            strName = pstrName;
            dblWidth = pdblWidth;
            dblHeight = pdblHeight;
        }

        //Methods
        public double fnCalcPerimeter()
        {
            dblPerimeter = ((dblWidth * 2) + (dblHeight * 2));
            return dblPerimeter;
        }
        public double fnCalcArea()
        {
            dblArea = (dblWidth * dblHeight);
            return dblArea;
        }
    }
}
