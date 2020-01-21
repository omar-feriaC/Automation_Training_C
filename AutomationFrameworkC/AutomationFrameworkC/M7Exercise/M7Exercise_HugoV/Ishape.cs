using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_HugoV
{
    interface IShape
    {

        double dblArea { get; set; }
        double dblPerimeter { get; set;}


        void DisplayInfo();

    }
}
