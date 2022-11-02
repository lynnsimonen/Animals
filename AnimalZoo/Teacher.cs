using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class Teacher : Person, ITalkable
    {
        private int Age;
        public Teacher(int age, string name) : base(name)
        {
            this.Age = age;
        }

        public int getAge()
        {
            return Age;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }

        public string talk()
        {
            return "Don't forget to do the assigned reading!";
        }


        public override String ToString()
        {
            return $"Teacher: name={Name}, age={Age}";
        }
    }
}