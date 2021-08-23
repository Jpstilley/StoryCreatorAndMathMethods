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
    }
}
