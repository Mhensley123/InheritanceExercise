using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            var myBird = new bird();
            {
                myBird.Wingspan =5;
                myBird.StateBird = "Indiana";
                myBird.EatsWorms = true;
                myBird.CanSing = true;

                var lizard = new reptile()
                {
                    IsScary = true,
                    IsPoisonous = true,
                    Habitat = "swamp",
                    IsSlimy = true
                };

                var myAnimals = new animal[] { myBird, lizard };
                
                foreach(var animal in myAnimals)
                {
                    Console.WriteLine($"Mammal: {animal.IsAMammal}");
                    Console.WriteLine($"Lifespan: {animal.Lifespan}");
                    Console.WriteLine($"AverageWeight: {animal.AverageWeight}");
                    Console.WriteLine($"CanBeAPet: {animal.CanBeAPet}");
                    Console.WriteLine($"");
                }
            };


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
