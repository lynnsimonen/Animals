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
        public Cat(int mousesKilled, string name) : base(name)
        {
            this.MousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return MousesKilled;
        }

        public void addMouse()
        {
            MousesKilled++;
        }

        public string talk()
        {
            return "Meow!";
        }


        public override String ToString()
        {
            return $"Cat: name={Name}, mousesKilled={MousesKilled}";
        }
    }

}