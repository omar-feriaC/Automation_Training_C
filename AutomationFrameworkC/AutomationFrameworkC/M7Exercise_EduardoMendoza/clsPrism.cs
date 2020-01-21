using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_EduardoMendoza
{
    class clsPrism : cls3D_Shape
    {
        //Attributes
        public double dblLength { get; set; }
        public double dblWidth { get; set; }
        public double dblHeight { get; set; }

        //Constructor
        public clsPrism()
        {
            strName = "";
            dblLength = 0.0;
            dblWidth = 0.0;
            dblHeight = 0.0;
        }

        public clsPrism(string pstrName, double pdblLength, double pdblWidth, double pdblHeight)
        {
            strName = pstrName;
            dblLength = pdblLength;
            dblWidth = pdblWidth;
            dblHeight = pdblHeight;
        }

        //Methods
        public double fnCalculatePerimeter()
        {
            dblPerimeter = (2 * dblWidth) + (2 * dblLength);
            return dblArea;
        }

        public double fnCalculateArea()
        {
            dblArea = dblWidth * dblLength;
            return dblArea;
        }

        public double fnCalculateVolume()
        {
            dblVolume = dblWidth * dblLength * dblHeight;
            return dblVolume;
        }
    }
}
