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
            string answer;
            System.Console.WriteLine("Let's create a pet zoo!!!");
            do
            {
                CreateZoo newZoo = new CreateZoo();
                newZoo.ZooInfo();
                System.Console.WriteLine("Would you like to create another new zoo pet?");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");


            // Lines to Replace Begin Here
            //zoo.add(new Dog(true, "Bean"));
            //zoo.add(new Cat(9, "Charlie"));
            //zoo.add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace
        }
    }
}
