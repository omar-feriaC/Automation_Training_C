using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise
{
    class clsPyramid : cls3D_Shape
    {
        //Attributes
        public double dblLength { get; set; }
        public double dblWidth { get; set; }
        public double dblHeight { get; set; }

        //Constuctor
        public clsPyramid() { }
        public clsPyramid(string pstrName, double pdblLength, double pdblWidth, double pdblHeight)
        {
            strName = pstrName;
            dblLength = pdblLength;
            dblWidth = pdblWidth;
            dblHeight = pdblHeight;
        }

        //Methods        
        public double fnCalcArea()
        {
            dblArea = (dblWidth * dblLength);
            return dblArea;
        }

        public double fnCalVolume()
        {
            dblVolume = ((dblArea * dblHeight) / 3);
            return dblVolume;
        }
    }
}