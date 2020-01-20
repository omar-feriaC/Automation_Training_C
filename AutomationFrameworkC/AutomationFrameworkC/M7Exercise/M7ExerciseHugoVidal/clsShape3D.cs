using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7ExerciseHugoVidal
{
    class clsShape3D : IShape
    {
        //Attributes from the IShape
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }

        //Attribute specifically from clsShape3D
        public string strName { get; set; }
        public double dblVolume { get; set; }

        //Constructor
        //Empty One JUST IN CASE*
        public clsShape3D() { }

        //other already initialized, and requesting the Name, since it is undefined
        public clsShape3D(string pstrName)
        {
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
            strName = pstrName;
        }

        //other already initialized, and requesting NOTHING, having the name = "Undifined"
        //public clsShape3D()
        //{
        //    dblArea = 0;
        //    dblPerimeter = 0;
        //    dblVolume = 0;
        //    strName = "Undifined";
        //}


        //other to provide the values of parameters, just in case you want
        public clsShape3D(double pdblArea, double pdblPerimeter, double pdblVolume, string pstrName)
        {
            dblArea = pdblArea;
            dblPerimeter = pdblPerimeter;
            dblVolume = pdblVolume;
            strName = pstrName;
        }


        //Methods from the IShape
        public void fnDisplayInfo()
        {
            Console.WriteLine("We are displaying the info for clsShape3D");
            Console.WriteLine("the NAME in clsShape3D is: " + strName);
            Console.WriteLine("the Area in clsShape3D is: " + dblArea);
            Console.WriteLine("the Perimeter in clsShape3D is: " + dblPerimeter);
            Console.WriteLine("the Volume in clsShape3D is: " + dblVolume);
            
        }

        public double fnCalculateVolume()
        {
            return dblVolume;
        }
    }
}
