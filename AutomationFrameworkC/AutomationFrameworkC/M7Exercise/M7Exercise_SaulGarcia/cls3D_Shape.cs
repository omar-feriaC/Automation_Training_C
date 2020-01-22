using AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Base_Files
{
    class cls3D_Shape : IShape
    {
        //Attributes
        public string strName { get; set; }
        public double dblBaseArea { get; set; }
        public double dblPerimeter { get; set; }
        public double dblVolume { get; set; }
        public double dblArea { get; set; }
    

        //Constructor

        public cls3D_Shape()
        {
            strName = "Undefined";
            dblBaseArea = 0.0;
            dblPerimeter = 0.0;
            dblVolume = 0.0;
        }

        public cls3D_Shape(string pstrName, double pdblBaseArea, double pdblPerimeter, double pdblVolume)
        {
            strName = pstrName;
            dblBaseArea = pdblBaseArea;
            dblPerimeter = pdblPerimeter;
            dblVolume = pdblVolume;
        }

        //Methods

        public void fnDisplayInfo()
        {
            Console.WriteLine("strName:" + strName);
            Console.WriteLine("dblBaseArea" + dblBaseArea);
            Console.WriteLine("dblPerimeter" + dblPerimeter);
            Console.WriteLine("dblVolume" + dblVolume);
        }

        public void fnGetArea()
        {
            throw new NotImplementedException();
        }

        public void fnGetPerimeter()
        {
            throw new NotImplementedException();
        }

        public void fnGetVolume()
        {
            throw new NotImplementedException();
        }

        public void fnGetBaseArea()
        {
            throw new NotImplementedException();
        }
    }
}