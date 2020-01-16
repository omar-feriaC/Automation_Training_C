
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Exercise;
using AutomationFrameworkC.Exercise2;
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
            clsDogs objDog = new clsDogs("Poodle", "MyDog", "Howl", "Small", "Male", "Home", "Medium", 10);
            objDog.fnDisplayInfo();

            Console.WriteLine("");
            Console.WriteLine("Constructor without parameters");
            clsClassicCar objCCar = new clsClassicCar();
            objCCar.fnBrake();
            objCCar.fnParking();
            objCCar.fnStart();
            objCCar.fnCalculateKM();
            objCCar.fnDisplayInfo();

            Console.WriteLine("");
            Console.WriteLine("Constructor with parameters");
            clsClassicCar objCCar2 = new clsClassicCar("A", "B", "C", "D", "E");
            objCCar2.fnBrake();
            objCCar2.fnParking();
            objCCar2.fnStart();
            objCCar2.fnCalculateKM();
            objCCar2.fnDisplayInfo();


            Console.WriteLine("");
            Console.WriteLine("Constructor with parameters");
            clsVW objCCar3 = new clsVW("A", "B", "C", "D", "E");
            objCCar3.fnBrake();
            objCCar3.fnParking();
            objCCar3.fnStart();
            objCCar3.fnCalculateKM();
            objCCar3.fnDisplayInfo();

            Console.ReadKey();

        }
    }
}
