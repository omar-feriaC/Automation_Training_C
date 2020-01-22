using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_OmarGonzalez
{
    class cls2DShape : IShape
    {
        //Attributes
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        public string strName { get; set; }


        //Constructor
        public cls2DShape() 
        {
            strName = "";
            dblPerimeter = 0.0;
            dblArea = 0.0;
        }

        public cls2DShape(string pstrName, double pdblPerimeter, double pdblArea)
        {
            strName = pstrName;
            dblPerimeter = pdblPerimeter;
            dblArea = pdblArea;
        }

        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("************2D Shape************");
            Console.WriteLine("strName:      " + strName);
            Console.WriteLine("dblperimeter: " + dblPerimeter);
            Console.WriteLine("dblarea:      " + dblArea);
            Console.WriteLine("********************************");
            Console.WriteLine("");
        }


    }
}
