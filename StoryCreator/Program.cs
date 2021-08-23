using System;

namespace StoryCreator
{
    class Program
    {
        public static int sum = 0;
        public static int product = 0;
        public static int quotient = 0;
        public static int difference = 0;

        static void Main(string[] args)
        {
            var wildCard = 5;

            Multiply(6, 5, 5, 10, wildCard, 15, 25);
            Console.WriteLine(product);

            Adding(7, 8, 9, 2, wildCard, 3, 5);
            Console.WriteLine(sum);

            Subtract(345, 35, 29, wildCard, 89);
            Console.WriteLine(difference);

            Divide(10000, 2, 3, 2, wildCard);
            Console.WriteLine(quotient);

            Console.WriteLine(CreateStory());
        }

        public static void Adding(params int[] parameters)
        {
            int result = 0;
            foreach(int parameter in parameters)
            {
                result += parameter;
            }
            sum = result;
        }

        public static void Subtract(params int[] parameters)
        {
            int result = 0;
            foreach (int parameter in parameters)
            {
                result -= parameter;
            }
            difference = result;
        }

        public static void Multiply(params int[] parameters)
        {

            int result = 1;
            for(int i = 0; i < parameters.Length; i++)
            {
                result *= parameters[i];
            }
            product = result;
        }

        public static void Divide(params int[] parameters)
        {

            int result = parameters[0] / parameters[1];
            for (int i = 2; i < parameters.Length; i++)
            {
                result /= parameters[i];
            }
            quotient = result;
        }

        public static string CreateStory()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("What is a silly word?");

            string sillyWord = Console.ReadLine();

            Console.WriteLine("Enter a number.");

            string number = Console.ReadLine().ToLower();

            Console.WriteLine("Enter an adjective.");

            string adjective1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter a noun.");

            string noun = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");

            string adjective2 = Console.ReadLine();

            Console.WriteLine("Enter a family relative type.");

            string relative = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");

            string adjective3 = Console.ReadLine();

            Console.WriteLine("Enter a verb.");

            string verb = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");

            string adjective4 = Console.ReadLine();

            Console.WriteLine("Enter another adjective.");

            string adjective5 = Console.ReadLine();

            string madLib = $"Hello, my name is {name} I am on my way to the planet {sillyWord}.\nI will be gone for {number} days." +
                                 $"\nI am very {adjective1} about the trip but I will miss my {noun}.\nI have heard the atmosphere their is " +
                                 $"{adjective2}.\nLuckily my {relative} packed me a jacket to keep me {adjective3}.\nWhen I land of the planet, I will {verb} for joy." +
                                 $"\nI am {adjective4} to walk on another planet.\nI could not be more {adjective5} for this trip!";

            return madLib;
        }

    }
}
