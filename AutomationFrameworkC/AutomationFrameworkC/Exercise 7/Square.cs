using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise_7
{
    class Square : Shape_2D
    {
        private double dblSide;

        public Square()
        {
            dblArea = 0;
            dblPerimeter = 0;
            strName = "Square";
        }

        public Square(double pdblSide)
        {
            dblArea = 0;
            dblPerimeter = 0;
            strName = "Square";
            dblSide = pdblSide;
        }

        private double CalculatePerimeter()
        {
            return dblPerimeter = dblSide * 4;
        }

        public double CalculateArea()
        {
            return dblArea = dblSide * dblSide;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n\n Given the following shape: {strName}");
            Console.WriteLine("Perimeter is = {0}", CalculatePerimeter());
            Console.WriteLine("Area is = {0}", CalculateArea());
        }

    }
}
