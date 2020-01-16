using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise2
{
    class clsAnimals : IAnimals
    {
        //Attributes
        public string strType { get; set; }
        public string strName { get; set; }
        public string strSound { get; set; }
        public string strSize { get; set; }
        public string strGender { get; set; }

        //Constructor
        public clsAnimals() { }

        public clsAnimals(string pstrType, string pstrName, string pstrSound, string pstrSize, string pstrGender)
        {
            strType = pstrType;
            strName = pstrName;
            strSound = pstrSound;
            strSize = pstrSize;
            strGender = pstrGender;
        }

        //Methods
        public void fnBreed()
        {
            Console.WriteLine("clsAnimlas: Breed: ");
        }

        public void fnEat()
        {
            Console.WriteLine("clsAnimlas: Eat: ");
        }

        public void fnGetSound()
        {
            Console.WriteLine("clsAnimlas: Sound: ");
        }

        public void fnWalk()
        {
            Console.WriteLine("clsAnimlas: Walk: ");
        }


    }
}
