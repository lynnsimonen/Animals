using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animals.AnimalZoo;

namespace Animals.AnimalZoo
{
    public class Dog : Pet, ITalkable
    {
        public bool Friendly { get; set; }
        public Dog(bool friendly, string name) : base(name)
        {
            this.Friendly = friendly;
        }

        public string talk(){
            return "roof, roof!";
        }


        public bool IsFriendly()
        {
            return Friendly;
        }

        public override string ToString()
        {
           return $"Dog: name={Name}, friendly={Friendly} ";
        }
    }
}