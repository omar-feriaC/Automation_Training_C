using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise_7
{
    class Prism : Shape_3D
    {
        private double dblVolume;
        private double dblHigh;
        private double dblArea;
        private double dblSide;

        public Prism()
        {
            dblArea = 0;
            dblHigh = 0;
            dblVolume = 0;
            strName = "Quadrangular Prism";
        }

        public Prism(double pdblHigh, double pdblSide)
        {
            dblHigh = pdblHigh;
            dblSide = pdblSide;
            strName = "Quadrangular Prism";
        }

        public double CalculateArea()
        {
            return dblArea = dblSide * dblSide;
        }

        private double CalculateVolume()
        {
            this.CalculateArea();
            return dblVolume = dblArea * dblHigh;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n Given the following shape: {strName}");
            Console.WriteLine("Volume is = {0}", CalculateVolume());
        }
    }
}
