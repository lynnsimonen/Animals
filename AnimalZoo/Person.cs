using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public abstract class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public string getName()
        {
            return Name;
        }
    }
}