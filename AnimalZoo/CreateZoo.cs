using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.AnimalZoo
{
    public class CreateZoo
    {
        public List<Pet> Pets { get; set; }


        public List<Pet> PetList()
        {
            Pets = new List<Pet>();
            return Pets;
        }
        public List<Pet> ZooInfo()
        {
            string typeAnimal;
            string name;
            int miceKilled;
            string askFriendly;
            bool friendly;
            string answer;

            PetList();

            do
            {

                //Ask the user what type of animal they want to create

                //do
                //{
                System.Console.WriteLine("What type of animal would you like to create? Cat - C or Dog - D");
                // try
                // {
                typeAnimal = Console.ReadLine().ToUpper();
                // }
                // catch (System.FormatException e)
                // {
                //     Console.WriteLine($"Exception - {e}");
                // }

                // System.Console.WriteLine("");

                //} while ((typeAnimal != "C") || (typeAnimal != "D"));

                //Create an object of that type 
                //Add the object to the ArrayList 

                //System.Console.WriteLine("What is your pet's name?");
                //name = Console.ReadLine();

                //Accept the input(s) necessary to instantiate that type of object

                if (typeAnimal == "C")
                {
                    System.Console.WriteLine("What is your pet's name?");
                    name = Console.ReadLine();
                    System.Console.WriteLine("How many mice has your cat killed?");
                    miceKilled = Convert.ToInt32(Console.ReadLine());
                    Pets.Add(new Cat(miceKilled, name));

                }
                else if (typeAnimal == "D")
                {
                    System.Console.WriteLine("What is your pet's name?");
                    name = Console.ReadLine();
                    System.Console.WriteLine("Is your dog friendly? Yes - Y, No - N");
                    askFriendly = Console.ReadLine().ToUpper();
                    if (askFriendly == "Y")
                    {
                        friendly = true;
                    }
                    else
                        friendly = false;
                    Pets.Add(new Dog(friendly, name));
                }
                System.Console.WriteLine("Would you like to create another new zoo pet Yes - Y, No - N?");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
            return Pets;
        }
    }
}