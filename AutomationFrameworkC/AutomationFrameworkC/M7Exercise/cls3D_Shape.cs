using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise
{
    public class cls3D_Shape : cls2D_Shape
    {
        //Attributes
        public double dblVolume { get; set; }

        //Constuctor
        public cls3D_Shape()
        //public cls3D_Shape() : base()
        {
            strName = "";
            dblArea = 0.0;
            dblVolume = 0.0;
        }

        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("Display 3D Shape Info:");
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Volume: " + dblVolume + "cm3");
            //Console.WriteLine("dblBaseArea: " + base.dblArea);
        }
    }
}
