using System;

namespace StoryCreator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(CreateStory());
        }

        public static string CreateStory()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is a silly word?");
            var sillyWord = Console.ReadLine();

            Console.WriteLine("Enter a number.");
            var number = Console.ReadLine().ToLower();

            Console.WriteLine("Enter an adjective.");
            var adjective1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter a noun.");
            var noun = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");
            var adjective2 = Console.ReadLine();

            Console.WriteLine("Enter a family relative type.");
            var relative = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");
            var adjective3 = Console.ReadLine();

            Console.WriteLine("Enter a verb.");
            var verb = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");
            var adjective4 = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");
            var adjective5 = Console.ReadLine();

            var madLib = $"Hello, my name is {name} I am on my way to the planet {sillyWord}.\nI will be gone for {number} days." +
                            $"\nI am very {adjective1} about the trip but I will miss my {noun}.\nI have heard the atmosphere their is " +
                            $"{adjective2}.\nLuckily my {relative} packed me a jacket to keep me {adjective3}.\nWhen I land of the planet, I will {verb} for joy." +
                            $"\nI am {adjective4} to walk on another planet.\nI could not be more {adjective5} for this trip!";

            return madLib;
        }

    }
}
