using System.Xml.Linq;
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
            System.Console.WriteLine("\nLet's create a talking zoo!!!\n");

            List<ITalkable> Zoo = new List<ITalkable>();

            // Lines to Replace Begin Here
            Zoo.Add(new Dog(true, "Bean"));
            Zoo.Add(new Cat(9, "Charlie"));
            Zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (ITalkable talker in Zoo)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"{talker.getName()} says =  {talker.talk()}");
                System.Console.WriteLine($"{talker.getName()}|{talker.talk()}\n---");
            }
        }
    }
}
// Lines to Replace Begin Here
//zoo.add(new Dog(true, "Bean"));
//zoo.add(new Cat(9, "Charlie"));
//zoo.add(new Teacher(44, "Stacy Read"));
// End Lines to Replace

