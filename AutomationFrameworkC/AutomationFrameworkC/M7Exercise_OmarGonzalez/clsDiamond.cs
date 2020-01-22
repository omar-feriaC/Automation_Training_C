using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_OmarGonzalez
{
    class clsDiamond : cls2DShape
    {
        //Atributtes

        //Constructor
        public clsDiamond()
        {
            strName = "";
            dblPerimeter = 0.0;
            dblArea = 0.0;
        }

        public clsDiamond(string pstrName,  double pdblPerimeter, double pdblArea )
        {
            strName = pstrName;
            dblPerimeter = pdblPerimeter;
            dblArea = pdblArea;
        }

        public clsDiamond(string pstrName)
        {
            strName = pstrName;
        }

        //Methods
        public double fnPerimeter(double pdblSide) 
        {
            dblPerimeter = pdblSide * 4;
            return dblPerimeter;
        }

        public double fnArea(double pdblDiagonalMinor, double pdblDiagonalMajor)
        {
            dblArea = (pdblDiagonalMinor * pdblDiagonalMajor) / 2;
            return dblArea;
        }

    }
}
