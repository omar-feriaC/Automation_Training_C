using AutomationFrameworkC.Animals;
using AutomationFrameworkC.Exercise;
using AutomationFrameworkC.Exercise3Nomina;
using System;

namespace AutomationFrameworkC
{
    class Program
    {
        static void Main(string[] args)
        {
            ////i can instaniate this with no parameters
            //Console.WriteLine("-------------------");
            //clsDogs objDogs = new clsDogs("poodle", "Smalone", 5, "Doggi", "DogPoodle","Howl","Small","male");
            //objDogs.fnDisplayInfo();
            //Console.WriteLine("-------------------");
            ////Console.WriteLine("Hello World!");
            ////this is the one that execute the program
            ////BaseTest.fnSetup();
            ////BaseTest.fnTearDown();
            ////when it is static it allows us to access directly to the function without any inizialization
            //// in the opposite way, an inizialitation is needed for example objDriver = new ChromeDriver();

            //clsClassicCar objCCar = new clsClassicCar();
            //objCCar.fnBrake();
            //objCCar.fnParking();
            //objCCar.fnStart();
            //objCCar.fnCalculateKM();
            //objCCar.fnDisplayInfo();

            ////with parameters
            //Console.WriteLine("Constructor with parameters");
            //clsClassicCar objCCar2 = new clsClassicCar("A","B","C", "D", "E");
            //objCCar2.fnBrake();
            //objCCar2.fnParking();
            //objCCar2.fnStart();
            //objCCar2.fnCalculateKM();
            //objCCar2.fnDisplayInfo();

            //Console.WriteLine("Constructor stablishing parameters in clsVW");
            //clsVW objclsVW = new clsVW();
            //objclsVW.fnDisplayInfo();

            //Console.WriteLine("Constructor sending parameters in clsVW with second constructor");
            //clsVW objclsVW2 = new clsVW("Ax", "Bx", "Cx", "Dx", "Ex");
            //objclsVW2.fnDisplayInfo();

            clsEmployee objEmployee = new clsEmployee("IDEMP001", "QAManual", "2 y 5m", 1000.0);
            objEmployee.fnGetInfo();

            Console.ReadKey(); //to wait something like a pause
        }
    }
}
