
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using AutomationFrameworkC.M7Exercise_OmarGonzalez;
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
            //Exercise #1
            cls2DShape obj2DShape = new cls2DShape("Square",20.00, 10.00);
            obj2DShape.fnDisplayInfo();
            cls3DShape obj3DShape = new cls3DShape("Sphere", 35.00, 25.00, 55.00, 67.00);
            obj3DShape.fnDisplayInfo();

            //Exercise #2
            clsDiamond objDiamond = new clsDiamond("Diamond");
            objDiamond.fnPerimeter(20.0);
            objDiamond.fnArea(10.6, 4.0);
            objDiamond.fnDisplayInfo();
            clsTetraedrom objTetraedrom = new clsTetraedrom("Tetraedrom", 20.00, 340.00, 12.00, 0.00);
            objTetraedrom.fnVolumen(2.0);
            objTetraedrom.fnDisplayInfo();

          

            Console.ReadKey();

        }
    }
}
