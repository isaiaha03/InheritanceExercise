using System;

namespace Inheritance
{
    class Program
    {
        class Animal
        {

            public int Age { get; set; }
            public string Species { get; set; }
            public int Legs { get; set; }
            public bool IsDomesticated { get; set; }
        }

        class Bird : Animal
        {

            public string Color { get; set; }
            public bool CanFly { get; set; }
            public bool HasBeak { get; set; }
            public string MigrationPattern { get; set; }
        }

        class Reptile : Animal
        {

            public bool IsColdBlooded { get; set; }
            public string ScaleType { get; set; }
            public bool CanRegenerate { get; set; }
            public bool HasTail { get; set; }
        }
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            //DONE Create a class Animal
            //DONE give this class 4 members that all Animals have in common

            //DONE Create a class Bird
            //DONE give this class 4 members that are specific to Bird
            //DONE Set this class to inherit from your Animal Class

            //DONE Create a class Reptile
            //DONE give this class 4 members that are specific to Reptile
            //DONE Set this class to inherit from your Animal Class


            /* DONE Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * DONE Creatively display the class member values 
             */

            Bird bird = new Bird
            {
                Species = "Eagle",
                Age = 5,
                Legs = 2,
                IsDomesticated = true,
                Color = "Brown",
                CanFly = true,
                MigrationPattern = "Migratory",
                HasBeak = true,
            };

            Console.WriteLine("Bird Information:");
            Console.WriteLine($"Species: {bird.Species}");
            Console.WriteLine($"Age: {bird.Age}");
            Console.WriteLine($"Legs: {bird.Legs}");
            Console.WriteLine($"Is Domesticated: {bird.IsDomesticated}");
            Console.WriteLine($"Color: {bird.Color}");
            Console.WriteLine($"Can Fly: {bird.CanFly}");
            Console.WriteLine($"Migration Pattern: {bird.MigrationPattern}");
            Console.WriteLine($"Has Beak: {bird.HasBeak}");
            Console.WriteLine();

            /* DONE Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * DONE Creatively display the class member values 
             */
            Reptile reptile = new Reptile
            {
                Species = "Snake",
                Age = 3,
                Legs = 0,
                IsDomesticated = false,
                IsColdBlooded = true,
                ScaleType = "Smooth",
                CanRegenerate = false,
                HasTail = true
            };

            Console.WriteLine("Reptile Information:");
            Console.WriteLine($"Species: {reptile.Species}");
            Console.WriteLine($"Age: {reptile.Age}");
            Console.WriteLine($"Legs: {reptile.Legs}");
            Console.WriteLine($"Is Domesticated: {reptile.IsDomesticated}");
            Console.WriteLine($"Is Cold Blooded: {reptile.IsColdBlooded}");
            Console.WriteLine($"Scale Type: {reptile.ScaleType}");
            Console.WriteLine($"Can Regenerate: {reptile.CanRegenerate}");
            Console.WriteLine($"Has Tail: {reptile.HasTail}");
        }
        

    }
}
