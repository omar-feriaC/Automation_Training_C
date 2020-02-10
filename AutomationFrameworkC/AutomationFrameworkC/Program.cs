
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise;
using AutomationFrameworkC.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            //RECTANGLE
            Console.WriteLine();
            cls2D_Shape objcls2D_Shape = new cls2D_Shape();
            objcls2D_Shape.fnDisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
            clsRectangle objclsRectangle = new clsRectangle("Rectangle", 10, 4);
            objclsRectangle.fnCalcArea();
            objclsRectangle.fnCalcPerimeter();
            objclsRectangle.fnDisplayInfo();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //PYRAMID
            Console.WriteLine();
            cls3D_Shape objcls3D_Shape = new cls3D_Shape();
            objcls3D_Shape.fnDisplayInfo();
            Console.WriteLine();
            Console.WriteLine();

            clsPyramid objclsPyramid = new clsPyramid("Pyramid", 4, 3, 4);
            objclsPyramid.fnCalcArea();
            objclsPyramid.fnCalVolume();
            objclsPyramid.fnDisplayInfo();
            Console.ReadKey();

        }
    }
}
