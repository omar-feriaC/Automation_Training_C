using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Animals
{
    class clsAnimals : IAnimal
    {
        public string strType { get; set; }
        public string strName { get; set; }
        public string strSound { get; set; }
        public string strSize { get; set; }
        public string strGender { get; set; }

        //CONSTRUCTOR
        public clsAnimals () {}  // the one that is kind of default

        public clsAnimals (string pstrType, string pstrName, string pstrSound, string pstrSize, string pstrGender)
        {
            strType = pstrType;
            strName = pstrName;
            strSound = pstrSound;
            strSize = pstrSize;
            strGender = pstrGender;
        }

        public void fnBreed()
        {
            Console.WriteLine("clsAnimals fnBreed: ");
        }

        public void fnEat()
        {
            Console.WriteLine("clsAnimals fnEat: ");
        }

        public void fnGetSound()
        {
            Console.WriteLine("clsAnimals fnGetSound: ");
        }

        public void fnWalk()
        {
            Console.WriteLine("clsAnimals fnWalk: ");
        }
    }
}
