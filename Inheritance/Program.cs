using System;
using Inheritance;

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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Toucan = new Bird("black feathers", true, "Long yellow Beak", 3);

            
            Console.WriteLine( $"A Toucan has {Toucan.WingsandFeathers} with a {Toucan.Beak} and {Toucan.OutputFly()} fly. It usually lays {Toucan.Eggs} a Year!" );


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var yourReptile = new Reptile();

            Console.WriteLine("Lets Make a Sentence with Your Reptile!");
            Console.WriteLine("How many Legs does your Reptile have?");

             var numCheck = int.TryParse(Console.ReadLine(), out var legInput);
             yourReptile.HaveLegs = legInput;

            while(!numCheck)
            {
                Console.WriteLine("How many Legs does your Reptile have?");

                numCheck = int.TryParse(Console.ReadLine(), out legInput);
                yourReptile.HaveLegs = legInput;
            }

            Console.WriteLine("Awesome! Where does your Reptile Live?");

            var reptileWhere = Console.ReadLine();
            yourReptile.WhereTheyLive = reptileWhere;

            Console.WriteLine("Cool! Is your Reptile Extinct?");

            var ans = Console.ReadLine();
            bool extinct;
            while (true)
            {
                ;
                if (ans != null && (ans == "y" || ans == "yes"))
                {
                    extinct = true;

                }
                else if (ans != null && (ans == "n" || ans == "no"))
                {
                    extinct = false;

                }
                else
                {
                    Console.WriteLine("Only y or n Allowed");
                    ans = Console.ReadLine();
                }
            }

            yourReptile.Existence = extinct;


            Console.WriteLine("Wow! Last question! What color scales does your reptile have?");

            var scales = Console.ReadLine();

            yourReptile.ExteriorBody = scales;

            Console.WriteLine($"Cool so your Reptile has {yourReptile.HaveLegs} leg(s) is {yourReptile.ExteriorBody} {yourReptile.IsExtinct()} and lives in {yourReptile.WhereTheyLive}!");

        }
    }
}
