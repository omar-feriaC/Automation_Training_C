using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_OmarGonzalez
{
    class clsTetraedrom : cls3DShape         
    {
        //Atributes

        //Constructor
        public clsTetraedrom()
        {
            strName = "";
            dblBase = 0.0;
            dblPerimeter = 0.0;
            dblArea = 0.0;
            dblVolumen = 0.0;
        }

        public clsTetraedrom(string pstrName, double pdblBase, double pdblPerimeter, double pdblArea, double pdblVolumen)
        {
            strName = pstrName;
            dblBase = pdblBase;
            dblPerimeter = pdblPerimeter;
            dblArea = pdblArea;
            dblVolumen = pdblVolumen;
        }
        
        //Methods
        public double fnVolumen (double pdblEdge)
        {
            dblVolumen = (Math.Sqrt(2)/12)*(Math.Pow(pdblEdge,3));
            return dblVolumen;
        }
    }
}
