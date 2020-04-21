
using AutomationFrameworkC.M7Exercise;
using AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC
{
    class Program
    {
        static void Main(string[] args)
        {
           Ellipse objEllipse1= new Ellipse(5, 4, 3.141592);
           objEllipse1.DisplayInfoEllipse();

            Console.WriteLine("*******************************");

            Console.ReadKey();

            Sphere objSphere1 = new Sphere(15);
            objSphere1.DisplayInfoSphere();

            Console.WriteLine("*******************************");

            Console.ReadKey();
             
        }
    }
}
