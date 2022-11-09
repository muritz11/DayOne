using System;
using System.Collections.Generic;

namespace BasicAuth
{
    internal class Program
    {

        public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

            public User(string name, string password, string email)
            {
                Name = name;
                Password = password;
                Email = email;
            }

        }

        static List<User> UsersList = new List<User>();

        static User RegisterUser()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = new User(name, password, email);
            return user;
        }

        static void Login()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool userFound = false;
            foreach (User user in UsersList)
            {
                if (user.Email == email)
                {
                    userFound = true;
                    if (user.Password == password)
                    {
                        Console.WriteLine("You're logged in!");
                    } else
                    {
                        Console.WriteLine("Incorrect password");
                    }
                } else
                {
                    Console.WriteLine("Not matching email");
                }
            }

            if (!userFound)
            {
                Console.WriteLine("Email does not exist");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Current users");
            //Program p = new Program();
            //foreach (var user in UsersList)
            //{
            //    Console.WriteLine($"{user}");
            //}
            Console.WriteLine(" Hello and Welcome, What would you like to do");
            Console.WriteLine(" A. Register \n B. Login");
            Console.Write("Enter an option: ");
            string option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "a":
                    // run
                    User newUser = RegisterUser();
                    UsersList.Add(newUser);
                    Console.WriteLine("Registration successful, You can now proceed to Login");
                    Login();
                    break;

                case "b":
                    // run
                    Login();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
