
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise_EduardoMendoza;
using System;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            //Part 2
            Console.WriteLine("2D Shape information PART 2");
            clsSquare objSquare = new clsSquare("Square", 5);
            objSquare.fnCalculatePerimeter();
            objSquare.fnCalculateArea();
            objSquare.DisplayInfo();
            Console.WriteLine("");

            Console.WriteLine("3D Shape information PART 2");
            clsPrism objPrism = new clsPrism("Rectangular Prism", 4, 6, 8);
            objPrism.fnCalculatePerimeter();
            objPrism.fnCalculateArea();
            objPrism.fnCalculateVolume();
            objPrism.DisplayInfo();
            Console.WriteLine("");
            Console.ReadKey();

            //Part 1
            Console.WriteLine("2D Shape information");
            cls2D_Shape obj2D_Shape = new cls2D_Shape();
            obj2D_Shape.DisplayInfo();
            Console.WriteLine("");

            Console.WriteLine("3D Shape information");
            cls3D_Shape obj3D_Shape = new cls3D_Shape();
            obj3D_Shape.DisplayInfo();
            Console.ReadKey();

        }
    }
}
