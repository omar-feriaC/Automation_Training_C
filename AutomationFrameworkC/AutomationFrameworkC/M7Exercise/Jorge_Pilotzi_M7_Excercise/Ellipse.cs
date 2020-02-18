using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise
{
    class Ellipse : _2DShape , IShape
    {
        // Atributes
        double dblA { get; set; }
        double dblB { get; set; }
        double dblPI { get; set; }
        string strName { get; set; }




        //Constructors
        public Ellipse()
        {
            strName = "Ellipse";
            dblA = 0;
            dblB = 0;
            
        }

        public Ellipse(double pdblA, double pdblB, double pdblPI)
        {
            strName = "Ellipse";
            dblA = pdblA;
            dblB = pdblB;
            dblPI = pdblPI;
        }

        //Method
        private double CalcPerimeter()
        {
            dblPerimeter = (double)2 * dblPI * Math.Sqrt((dblA * dblA + dblB * dblB) / (2 * 1.0));
            return dblPerimeter;
        }

        private double CalcArea()
        {
            dblArea = dblPI * dblA * dblB;
            return dblArea;
        }

        public void DisplayInfoEllipse()
        {
            CalcArea();
            CalcPerimeter();
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Perimeter: " + CalcPerimeter());
            Console.WriteLine("Area: " + CalcArea());

        }
    }
}
