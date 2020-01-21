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

        //Attribute specifically for clsShape2D
        public string strName { get; set; }

        //Constructor
        public clsShape2D(){ }

        //One requested already initialized with 0 and Name
        public clsShape2D(string pstrName)
        {
            dblArea = 0;
            dblPerimeter = 0;
            strName = pstrName;
        }

        //Other to provide all the values to print
        public clsShape2D(double pdblArea, double pdblPerimeter, string pstrName)
        {
            dblArea = 0;
            dblPerimeter = 0;
            strName = pstrName;
        }

        //Methods from the IShape
        public void fnDisplayInfo()
        {
            Console.WriteLine("We are displaying the info for clsShape2D");
            Console.WriteLine("the NAME is: " + strName);
            Console.WriteLine("the Area is: " + dblArea);
            Console.WriteLine("the Perimeter is: " + dblPerimeter);
        }

    }
}
