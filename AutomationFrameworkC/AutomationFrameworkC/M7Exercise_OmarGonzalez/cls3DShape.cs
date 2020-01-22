using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_OmarGonzalez
{
    class cls3DShape : cls2DShape
    {
        //Attributes
        public double dblBase;
        public double dblVolumen;
        
        //Constructor 
        public cls3DShape()
        {
            strName = "";
            dblBase = 0.0;
            dblPerimeter = 0.0;
            dblArea = 0.0;
            dblVolumen = 0.0;
        }

        public cls3DShape(string pstrName, double pdblBase, double pdblPerimeter, double pdblArea, double pdblVolumen)
        {
            strName = pstrName;
            dblBase = pdblBase;
            dblPerimeter = pdblPerimeter;
            dblArea = pdblArea;           
            dblVolumen = pdblVolumen;
        }

        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("************3D Shape************");
            Console.WriteLine("strName:      " + strName);
            Console.WriteLine("dblBase:      " + dblBase);
            Console.WriteLine("dblPerimeter: " + dblPerimeter);
            Console.WriteLine("dblArea:      " + dblArea);
            Console.WriteLine("dblVolumen:   " + dblVolumen);
            Console.WriteLine("********************************");
            Console.WriteLine("");
        }
    }
}
