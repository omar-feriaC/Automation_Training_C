
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
            cls2DShape obj2DShape = new cls2DShape("Square",20.00, 10.00);
            obj2DShape.fnDisplayInfo();
            cls3DShape obj3DShape = new cls3DShape("Sphere", 35.00, 25.00, 55.00, 67.00);
            obj3DShape.fnDisplayInfo();

            Console.ReadKey();

        }
    }
}
