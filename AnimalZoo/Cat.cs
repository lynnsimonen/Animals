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
            return $"My cat, {petName}, says \"meow, meow\"";
        }

        public override string SpecialSkill()
        {
            return "My cat killed {MousesKilled} mice!";
        }
    }
}