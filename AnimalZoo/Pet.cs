using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public abstract class Pet
    {
        protected string Name {get; set;}

        public Pet (string name)
        {
            this.Name = name;
        }

    }
}