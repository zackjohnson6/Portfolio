using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Pig: Animal
    {
        private string name = null;

        public Pig() 
        { 
            animalName= "pig";
        }



        public void pigName(string newPigName)
        {
            this.name = newPigName;
        }

        public override string Speak()
        {
           return " named " + this.name + " oinks!";
        }
    }
}
