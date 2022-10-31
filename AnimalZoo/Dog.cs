using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Dog : Pet//, ITalkable
    {
        private bool Friendly { get; set; }
        public Dog(bool friendly, string petName) : base(petName)
        {
            this.Friendly = friendly;
        }

        public override string ToString()
        {
            return $"My dog, {petName}, says \"roof, roof\"!";
        }

        public override string SpecialSkill()
        {
           return "My dog is friendly? {Friendly}";
        }
    }
}