using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise
{
    public class cls2D_Shape : IShape
    {
        //Attributes
        public string strName { get; set; }
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }

        //Constuctor
        public cls2D_Shape()
        {
            strName = "";
            dblArea = 0.0;
            dblPerimeter = 0.0;
        }

        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("Display 2D Shape Info:");
            Console.WriteLine("strName: " + strName);
            Console.WriteLine("dblArea: " + dblArea);
            Console.WriteLine("dblPerimeter: " + dblPerimeter);
        }
    }
}
