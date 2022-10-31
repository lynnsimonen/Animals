using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Cat : Pet//, ITalkable
    {
        private int MousesKilled;
        public Cat(int mousesKilled, string petName) : base(petName)
        {
            this.MousesKilled = mousesKilled;
        }

        public override string ToString()
        {
            return "meow";
        }

        public override void animal()
        {
            System.Console.WriteLine($"The cat named, {petName}, says \"meow, meow\".  {petName} has killed {MousesKilled} mice!");
        }
    }
}