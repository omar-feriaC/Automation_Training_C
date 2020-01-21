
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using AutomationFrameworkC.M7Exercise.M7Exercise_HugoV;
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
           

           clsShape2D objShape2D = new clsShape2D();
            objShape2D.DisplayInfo();

            Console.WriteLine("");

            clsShape3D objShape3D = new clsShape3D();
            objShape3D.DisplayInfo();

            Console.WriteLine(" ");
            Console.WriteLine("Hugo Vazquez");

            Console.ReadKey();


        }
    }
}
