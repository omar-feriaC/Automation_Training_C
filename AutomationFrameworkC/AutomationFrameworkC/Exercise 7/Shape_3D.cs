using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise_7
{
    class Shape_3D : Shape_2D
    {
        protected double dblVolume;

        public Shape_3D()
        {
            strName = "Quadrangular Prism";
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Information from 3D Shape: \n Name={strName} \n Volume= {dblVolume}");
        }

    }
}