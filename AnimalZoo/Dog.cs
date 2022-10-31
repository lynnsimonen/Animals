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
            return "roof, roof!";
        }

        public override void animal()
        {
            System.Console.WriteLine($"The dog named, {petName}, says \"roof, roof\"!. (Friendly? {Friendly})");
        }
    }
}