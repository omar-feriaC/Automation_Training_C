
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise.M7ExerciseHugoVidal;
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
            //Implementing the use of the 2 classes
            //Instantiating the clsShape2D
            Console.WriteLine("---------PART 1----------");
            clsShape2D objShape2D = new clsShape2D("Undefined in shape2D");
            objShape2D.fnDisplayInfo();
            Console.WriteLine("-------------------");
            //Instantiating the clsShape3D
            clsShape3D objShape3D = new clsShape3D("Undefined in shape3D");
            objShape3D.fnDisplayInfo();
            Console.WriteLine(" ");
            //Part 2 of the Exercise
            Console.WriteLine("---------PART 2----------");
            clsShape1Square objSquare = new clsShape1Square(10.5, "The Square");
            objSquare.fnCalculateSquareArea();
            objSquare.fnCalculatePerimeter();
            objSquare.fnDisplayInfo();
            Console.WriteLine("-------------------");
            clsShape2Cylinder objCylinder = new clsShape2Cylinder("The Cylinder", 5.8, 7.4);
            objCylinder.fnCalculateCylinderVolume();
            objCylinder.fnDisplayInfo();
            Console.ReadKey();

        }
    }
}
