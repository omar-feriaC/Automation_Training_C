﻿
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Exercise;
using AutomationFrameworkC.Exercise2;
using AutomationFrameworkC.Exercise3;
using AutomationFrameworkC.Page_Objects;
using AutomationFrameworkC.Reporting;
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


            Console.WriteLine("");
            Console.WriteLine("");

            string phrase = "Accounts;SubMenu1";
            string[] words = phrase.Split(';');


            for (int i=0; i<= words.Length -1 ; i++)
            {
                System.Console.WriteLine($"<{words[i]}>");

            }

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }


            clsReportManager objReport = new clsReportManager();
            string strTemp = objReport.fnReportPath();

            clsEmployee objEmployee = new clsEmployee("1ABC", "Programmer", "Sr", 1000.00);
            Console.WriteLine("Employee Class");
            objEmployee.fnGetInfo();
            Console.WriteLine();

            clsBaseEmployee objBEmployee = new clsBaseEmployee();
            objBEmployee.strID = "LLLLL";
            objBEmployee.strPosition = "";
            Console.WriteLine("Base Employee Class");
            objBEmployee.fnCalculateSalary();
            objBEmployee.fnGetInfo();
            Console.WriteLine();





            //clsDogs objDog = new clsDogs("Poodle", "MyDog", "Howl", "Small", "Male", "Home", "Medium", 10);
            //objDog.fnDisplayInfo();

            //Console.WriteLine("");
            //Console.WriteLine("Constructor without parameters");
            //clsClassicCar objCCar = new clsClassicCar();
            //objCCar.fnBrake();
            //objCCar.fnParking();
            //objCCar.fnStart();
            //objCCar.fnCalculateKM();
            //objCCar.fnDisplayInfo();

            //Console.WriteLine("");
            //Console.WriteLine("Constructor with parameters");
            //clsClassicCar objCCar2 = new clsClassicCar("A", "B", "C", "D", "E");
            //objCCar2.fnBrake();
            //objCCar2.fnParking();
            //objCCar2.fnStart();
            //objCCar2.fnCalculateKM();
            //objCCar2.fnDisplayInfo();


            //Console.WriteLine("");
            //Console.WriteLine("Constructor with parameters");
            //clsVW objCCar3 = new clsVW("A", "B", "C", "D", "E");
            //objCCar3.fnBrake();
            //objCCar3.fnParking();
            //objCCar3.fnStart();
            //objCCar3.fnCalculateKM();
            //objCCar3.fnDisplayInfo();

            Console.ReadKey();

        }
    }
}
