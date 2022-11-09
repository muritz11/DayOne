using System;

namespace LibraryMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Library");
            Console.WriteLine("Please choose one of the options below:");
            Console.WriteLine(" 1. C \n 2. O \n 3. D \n 4. E");
            Console.Write("Enter Input: ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "c":
                    Console.WriteLine("C# Books");
                    break;

                case "o":
                    Console.WriteLine(".NET core books");
                    break;

                case "d":
                    Console.WriteLine("Clean coding books");
                    break;

                case "e":
                    Console.WriteLine("EFCore books");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
