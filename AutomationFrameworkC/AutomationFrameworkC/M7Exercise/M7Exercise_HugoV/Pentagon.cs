using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_HugoV
{
    
    

        class Pentagon : clsShape2D
        {
            public double apothem;
            public int nSides;
            public double sLength;
       
        public Pentagon()
        {
            this.apothem = 0;
            this.nSides = 5;
            this.sLength = 0;
        }

        public Pentagon(double apothem, double sLength) : base("Pentagon")
            {
                this.apothem = apothem;
                this.nSides = 5;
                this.sLength = sLength;
            }

            public void perimetroPentagono()
            {
                dblPerimeter = nSides * sLength;
            }

            public void areaPentagono()
            {
                dblArea = (dblPerimeter * apothem) / 2;
            }

             public void valoresPentagano()
               {
                DisplayInfo();
               Console.WriteLine("Apothem: " + apothem);
               Console.WriteLine("Size: " + sLength);
               Console.WriteLine("Area of " + strName + " is: " + dblArea);
               }
    }
    

}

