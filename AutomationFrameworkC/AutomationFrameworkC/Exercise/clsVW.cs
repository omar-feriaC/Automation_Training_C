using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise
{
    class clsVW : clsClassicCar
    {
        //Attributes

        //Constructor
        public clsVW (string pstrEngine, string pstrTires, string pstrColor, string pstrModel, string pstrPlate)
        {
            strEngine = pstrEngine;
            strTires = pstrTires;
            strColor = pstrColor;
            strModel = pstrModel;
            strPlate = pstrPlate;
        }

        //Methods
        //public void fnBrake()
        //{
        //    Console.WriteLine("clsVW_fnBrake: ");
        //}

        //public void fnCalculateKM()
        //{
        //    Console.WriteLine("clsVW_fnCalculateKM");
        //}

        //public void fnParking()
        //{
        //    Console.WriteLine("clsVW_fnParking");
        //}

        //public void fnStart()
        //{
        //    Console.WriteLine("clsVW_fnStart");
        //}

        public new void fnDisplayInfo()
        {
            Console.WriteLine("clsVW_fnDisplayInfo");
            Console.WriteLine("strEngine: " + strEngine);
            Console.WriteLine("strTires: " + strTires);
            Console.WriteLine("strColor: " + strColor);
            Console.WriteLine("strModel: " + strModel);
            Console.WriteLine("strPlate: " + strPlate);
        }

    }
}
