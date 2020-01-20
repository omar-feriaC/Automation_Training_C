using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7ExerciseHugoVidal
{
    class clsShape2D : IShape
    {
        //Attributes from the IShape
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }

        //Attribute specifically from clsShape2D
        public double dblResult { get; set; }

        //Constructor
        //Empty One JUST IN CASE*
        public clsShape2D(){ }

        //other One using ONLY 2 parameters to PRINT
        public clsShape2D(double pdblArea, double pdblPerimeter)
        {
            dblArea = pdblArea;
            dblPerimeter = pdblPerimeter;
        }

        //other One using ALL the parameters
        public clsShape2D (double pdblArea, double pdblPerimeter, double pdblResult)
        {
            dblArea = pdblArea;
            dblPerimeter = pdblPerimeter;
            dblResult = pdblResult;
        }


        //Methods from the IShape
        public void fnDisplayInfo()
        {
            Console.WriteLine("We are displaying the info for clsShape2D");
            Console.WriteLine("the Area is: " + dblArea);
            Console.WriteLine("the Perimeter is: " + dblPerimeter);
        }

        public double fnCalculateShape2D()
        {
            return dblResult;
        }
    }
}
