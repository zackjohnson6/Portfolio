using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Dog : Animal
    {
        private string name = null;

        public Dog() 
        {
            animalName = "dog";
        }

      

        public void dogName(string newDogName)
        {
            this.name = newDogName;
        }

        public override string Speak()
        {
            return " named " + this.name + " barks!";
        }
    }
}
