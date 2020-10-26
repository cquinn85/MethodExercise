using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you:");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine("Do you have a pet?");
            string ownAnimal = Console.ReadLine();

            Console.WriteLine("What kind of pet?");
            string petType = Console.ReadLine();

            Console.WriteLine("What is his name?");
            string petName = Console.ReadLine();

            Console.WriteLine($" There is a girl named {userName}.");
            Console.WriteLine($"She is {age} years old.");
            Console.WriteLine($"Her favorite color is {faveColor}.");
            Console.WriteLine($"She has a {petType} named {petName}.");

           
        }
    }
}
