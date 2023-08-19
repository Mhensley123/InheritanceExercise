using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            


                var myBird = new Bird();
                myBird.Wingspan =6;
                myBird.StateBird = " ";
                myBird.EatsWorms = true;
                myBird.CanSing = true;

                var lizard = new Reptile()
                {
                    IsCute = true,
                    IsPoisonous = true,
                    Habitat = "swamp",
                    IsSlimy = false,
                };

                var myAnimals = new Animal[] { myBird, lizard };
                
                foreach(var animal in myAnimals)
                {
                    Console.WriteLine($"Mammal: {animal.IsAMammal}");
                    Console.WriteLine($"Lifespan: {animal.Lifespan} years old");
                    Console.WriteLine($"AverageWeight: {animal.AverageWeight} pounds");
                    Console.WriteLine($"CanBeAPet: {animal.CanBeAPet}");
                    Console.WriteLine($"");
                }
            


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
