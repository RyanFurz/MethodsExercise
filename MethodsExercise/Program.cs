using System.Globalization;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}! What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            
            Console.WriteLine($"On a hot summer day, {username} was looking for their {favoriteColor} shirt they had taken off earlier in the day. When they finally found it, a {favoriteAnimal} had fallen asleep on top of the shirt. To scare the {favoriteAnimal} off, {username} pulled out their phone and played a song from {favoriteBand} on full blast.");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum = sum + number;
                //sum += number;
            }
            
            return sum;
        }

        static void Main(string[] args)
        {
            Madlib();
            Console.WriteLine(Add(a:4, b:5));
            Console.WriteLine(Subtract(a:7, b:3));
            Console.WriteLine(Multiply(a:2, b:9));
            Console.WriteLine(Divide(a: 30, b: 2));
            Console.WriteLine(Sum(2, 4, 6, 8));
        }
    }
}
