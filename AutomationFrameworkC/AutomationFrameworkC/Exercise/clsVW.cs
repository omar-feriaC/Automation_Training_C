using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise
{
    class clsVW : clsClassicCar
    {
        // send information, using the methods of clsClassic

        //Constructor
        public clsVW()
        {
            strEngine = "VWEngine";  //we are inherith the "strEngine" attribute from clsClassicCar
            strTires = "VWTires";
            strColor = "VWColor";
            strModel = "VWModel";
            strPlate = "VWPlate";
        }

        public clsVW(string pstrEngine, string pstrTires, string pstrColor, string pstrModel, string pstrPlate)
        {
            strEngine = pstrEngine;
            strTires = pstrEngine;
            strColor = pstrColor;
            strModel = pstrModel;
            strPlate = pstrPlate;
        }

        //public new void fnDisplayInfo()  // We use new to add particular things into a function with same name
        //{
        //    Console.WriteLine("strEngine VW :" + strEngine);
        //    Console.WriteLine("strEngine VW :" + strTires);
        //    Console.WriteLine("strEngine VW :" + strColor);
        //    Console.WriteLine("strEngine VW :" + strModel);
        //    Console.WriteLine("strEngine VW :" + strPlate);
        //}

    }
}
