using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7ExerciseHugoVidal
{
    class clsShape1Square : clsShape2D
    {
        //Attributes
        public double dblLadoSize { get; set; }
        
        //Constructor
        // The constructor Emptyone just in case
        public clsShape1Square() { }

        public clsShape1Square(double pdblLadoSize, string pstrName)
        {
            dblLadoSize = pdblLadoSize;
            strName = pstrName;  // I'm inheriting from the class from clsShape2D
        }

        //Methods
        public double fnCalculateSquareArea()
        {
            dblArea = (dblLadoSize) * (dblLadoSize);  // I'm inheriting from the class from clsShape2D
            return dblArea;
        }

        public double fnCalculatePerimeter()
        {
            dblPerimeter = (dblLadoSize) * (4);  // I'm inheriting from the class from clsShape2D
            return dblPerimeter;
        }

        // here i am reusing the method to display the info
        // but since i am modifying the method, i am using "new"
        public new void fnDisplayInfo()
        {
            Console.WriteLine("We are displaying the info for Shape 1");
            Console.WriteLine("the NAME os Shape 1 is: " + strName);
            Console.WriteLine("the Value of the a side is: " + dblLadoSize);
            Console.WriteLine("the Area is: " + dblArea);
            Console.WriteLine("the Perimeter is: " + dblPerimeter);
        }

    }
}
