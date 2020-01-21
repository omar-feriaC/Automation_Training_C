using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_EduardoMendoza
{
    class clsSquare : cls2D_Shape
    {
        //Attributes
        public double dblSide { get; set; }

        
        //Constructor
        public clsSquare()
        {
            strName = "";
            dblSide = 0.0;
        }

        public clsSquare(string pstrName, double pdblSide)
        {
            strName = pstrName;
            dblSide = pdblSide;
        }


        //Methods
        public double fnCalculatePerimeter()
        {
            dblPerimeter = 4 * dblSide;
            return dblPerimeter;
        }

        public double fnCalculateArea()
        {
            dblArea = dblSide * dblSide;
            return dblArea;
        }
    }
}
