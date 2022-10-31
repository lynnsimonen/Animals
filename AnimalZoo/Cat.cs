using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Cat : Pet, ITalkable
    {
        private int MousesKilled;
        public Cat(int mousesKilled, string Name) : base(Name)
        {
            this.MousesKilled = mousesKilled;
        }

        public void talk()
        {
            System.Console.WriteLine($"The cat named, {Name}, says \"meow, meow\".  {Name} has killed {MousesKilled} mice!");
        }
    }
}