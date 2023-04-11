using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
   abstract internal class Animal
    {
        protected string animalName = "unknown";

        public virtual string GetAnimalName()
        {
            return animalName;
        }
        abstract public string Speak();
    }
}
