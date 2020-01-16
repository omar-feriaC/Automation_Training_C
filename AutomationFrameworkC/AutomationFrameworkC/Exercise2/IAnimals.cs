using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise2
{
    interface IAnimals
    {
        //Attributes
        string strType { get; set; }
        string strName { get; set; }
        string strSound { get; set; }
        string strSize { get; set; }
        string strGender { get; set; }

        //Methods
        void fnEat();
        void fnGetSound();
        void fnWalk();
        void fnBreed();


    }
}
