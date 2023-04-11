using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Cat : Animal
    {

        
            private string name = null;

            public Cat() 
            {
            animalName= "cat";
            }

            public void catName(string newCatName)
            {
                this.name = newCatName;
            }

            public override string Speak()
            {
              return " named " + this.name + " meows!";
            }
        }
    }

