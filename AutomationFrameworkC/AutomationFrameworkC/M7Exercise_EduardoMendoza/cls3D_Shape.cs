using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise_EduardoMendoza
{
    class cls3D_Shape : cls2D_Shape
    {
        //Attributes
        public double dblVolume { get; set; }
        //public double dblBaseArea { get; set; }

        //Constructor
        public cls3D_Shape()
        {
            strName = "undefined";
            dblArea = 0.0;
            dblPerimeter = 0.0;
            dblVolume = 0.0;
        }

        //Methods
        public new void DisplayInfo()
        {
            Console.WriteLine("Display 3D Shape Information");
            Console.WriteLine("strName: " + strName);
            Console.WriteLine("dblVolume: " + dblVolume);
            Console.WriteLine("dblBaseArea: " + dblArea);
            Console.WriteLine("dblBasePerimeter: " + dblPerimeter);
        }
    }
}
