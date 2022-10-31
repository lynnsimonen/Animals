using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Dog : Pet, ITalkable
    {
        private bool Friendly { get; set; }
        public Dog(bool friendly, string name) : base(Name)
        {
            this.Friendly = friendly;
        }

        public void talk()
        {
            System.Console.WriteLine($"The dog named, {Name}, says interface meow.");
        }
    }
}