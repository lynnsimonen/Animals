using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public abstract class Pet
    {
        protected string petName { get; set; }

        public Pet(string name)
        {
            this.petName = name;
        }

        public abstract void animal();

    }
}