
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Exercise;
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
            Console.WriteLine("Constructor without parameters");
            clsClassicCar objCCar = new clsClassicCar();
            objCCar.fnBrake();
            objCCar.fnParking();
            objCCar.fnStart();
            objCCar.fnCalculateKM();
            objCCar.fnDisplayInfo();

            Console.WriteLine("Constructor with parameters");
            clsClassicCar objCCar2 = new clsClassicCar("A", "B", "C", "D", "E");
            objCCar2.fnBrake();
            objCCar2.fnParking();
            objCCar2.fnStart();
            objCCar2.fnCalculateKM();
            objCCar2.fnDisplayInfo();


            Console.ReadKey();

        }
    }
}
