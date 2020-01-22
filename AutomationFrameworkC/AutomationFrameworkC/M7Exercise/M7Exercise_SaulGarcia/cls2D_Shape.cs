using AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Base_Files
{
    class cls2D_Shape : IShape
    {
        
        //Attributes
        public string strName { get; set; }
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        public double dblVolume { get; set; }
        public double dblBaseArea { get; set; }

        //Constructor
        public cls2D_Shape() 
    {
        strName = "Undefined";
        dblArea = 0.0;
        dblPerimeter = 0.0;
    }

        public cls2D_Shape(string pstrName, double pdblArea, double pdblPerimeter)
        {
            strName = pstrName;
            dblArea = pdblArea;
            dblPerimeter = pdblPerimeter;
        }

        //Methods

        public void fnDisplayInfo()
        {
            Console.WriteLine("strName:" + strName);
            Console.WriteLine("dblArea" + dblArea);
            Console.WriteLine("dblPerimeter" + dblPerimeter);
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
