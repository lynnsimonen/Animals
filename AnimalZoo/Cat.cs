using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Cat : Pet, ITalkable
    {
        private int MousesKilled;
        public Cat(int mousesKilled, string name) : base(Name)
        {
            this.MousesKilled = mousesKilled;
        }

        public void talk()
        {
            System.Console.WriteLine($"The cat named, {Name}, says interface meow.");
        }
    }
}