using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_HugoV
{
    class clsShape3D : IShape

    {
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        public string strName { get; set; }
        public double dblVolume { get; set; }

        public clsShape3D()
        {
            strName = "Undefined";
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;

        }

        public clsShape3D(string name)
        {
            this.strName = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Information for class Shape3D");
            Console.WriteLine("Name:" + strName);
            Console.WriteLine("Area:" + dblArea);
            Console.WriteLine("Perimeter:" + dblPerimeter);
            Console.WriteLine("Volume:" + dblVolume);

        }


    }
}
