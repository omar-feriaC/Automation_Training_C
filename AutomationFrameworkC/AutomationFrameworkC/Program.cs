
using AutomationFrameworkC.Base_Files;
//using AutomationFrameworkC.Exercise;
//using AutomationFrameworkC.Exercise2;
//using AutomationFrameworkC.Exercise3;
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

            //instantiating the clsShape2D

            clsShape2D objShape2D = new clsShape2D("Undefined in shape2D");
            objShape2D.fnDisplayInfo();

            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");

            clsShape3D objShape3D = new clsShape3D("Undefined in shape3D");
            objShape3D.fnDisplayInfo();


            Console.ReadKey();

        }
    }
}
