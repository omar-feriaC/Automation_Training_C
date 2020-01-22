using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_HugoV
{
    class clsShape2D : IShape
    {
        public double dblArea { get; set; }

        public double dblPerimeter { get; set; }

        public string strName { get; set; }


       
        public clsShape2D()
        {
            strName = "Undefined";
            dblArea = 0;
            dblPerimeter = 0;

        }

        public clsShape2D(string name)
        {
            this.strName = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Information for class Shape2D");
            Console.WriteLine("Name:" + strName);
            Console.WriteLine("Area:" + dblArea);
            Console.WriteLine("Perimeter:" + dblPerimeter);

        }
    }
}
