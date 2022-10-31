using System.Reflection;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.AnimalZoo;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Let's create a pet zoo!!!");

            CreateZoo newZoo = new CreateZoo();
            List<Pet> Pets = newZoo.ZooInfo();

            foreach (var pet in Pets)
            {
                System.Console.WriteLine(pet);
                //System.Console.WriteLine($"{pet.SpecialSkill}");
            }
        }
    }
}
// Lines to Replace Begin Here
//zoo.add(new Dog(true, "Bean"));
//zoo.add(new Cat(9, "Charlie"));
//zoo.add(new Teacher(44, "Stacy Read"));
// End Lines to Replace

