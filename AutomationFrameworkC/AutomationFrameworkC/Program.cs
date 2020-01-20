
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise_EduardoMendoza;
using System;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
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
