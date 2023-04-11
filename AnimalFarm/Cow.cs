using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Cow : Animal
    {
        private string name = null;

        public Cow()
        {
            animalName = "cow";
        }



        public void cowName(string newCowName)
        {
            this.name = newCowName;
        }

        public override string Speak()
        {
            return " named " + this.name + " moos!";
        }
    }
}
