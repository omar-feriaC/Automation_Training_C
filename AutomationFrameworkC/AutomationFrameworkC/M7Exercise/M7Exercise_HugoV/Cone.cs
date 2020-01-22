using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_HugoV
{
    class Cone : clsShape3D
    {

        public double radio;
        public double height;
        public double pi;


        public Cone()
        {
            this.radio=0;
            this.height = 0;
            this.pi = 3.1416;
        }
        public Cone(double radio, double height) : base("Cone")
        {
            this.radio = radio;
            this.height = height;
            this.pi = 3.1416;
        }

        public void volumeCone()
        {
            dblVolume = (((pi) * ((radio) * (radio))) * (height)) / 3;
        }

      

        public void valuesCone()
        {
            DisplayInfo();
            Console.WriteLine("Radio: " + radio);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Volume " + strName + " is: " + dblVolume);
        }
    }
}
