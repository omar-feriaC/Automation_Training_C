
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Exercise;
using AutomationFrameworkC.Exercise2;
using AutomationFrameworkC.Exercise3;
using AutomationFrameworkC.Page_Objects;
using AutomationFrameworkC.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Exercise_7;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            double pSide;//Variable to insert the value of the Side of the Square
            double pHigh;
            //Objects to access to methods
            Shape_2D objShape_2D = new Shape_2D();
            Shape_3D objShape_3D = new Shape_3D();

            objShape_2D.DisplayInfo();
            objShape_3D.DisplayInfo();

            //Square class 2D
            Console.WriteLine("\n\n Please insert a numeric value for the Side: ");
            pSide = Convert.ToDouble(Console.ReadLine());
            Square objSquare = new Square(pSide);
            objSquare.DisplayInfo();


            //Square class 3D
            Console.WriteLine("\n Calculate the Volume of a prism with same Size of previous 2D shape");
            Console.WriteLine("Please insert a numeric value for the Heigh of the prism: ");
            pHigh = Convert.ToDouble(Console.ReadLine());
            Prism objPrism = new Prism(pHigh, pSide);
            objPrism.DisplayInfo();

            Console.ReadKey();
        }
    }
}
