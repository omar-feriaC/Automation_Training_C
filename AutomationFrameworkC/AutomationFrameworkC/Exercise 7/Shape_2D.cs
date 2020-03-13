using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Exercise_7;

namespace AutomationFrameworkC.Exercise_7
{
    class Shape_2D : IShape
    {
        double IShape.area { get; set; }
        double IShape.perimeter { get; set; }
        string IShape.name { get; set; }

        protected string strName;
        protected double dblArea;
        protected double dblPerimeter;

        public Shape_2D()
        {
            strName = "Square";
            dblArea = 0;
            dblPerimeter = 0;
        }

        public void DisplayInfo()
        {
            Shape_2D objShape2D = new Shape_2D();
            Console.WriteLine($"Information from 2D Shape:  \n Name={strName} \n Perimeter = {dblPerimeter}  \n Area={dblArea}");
        }

    }
}