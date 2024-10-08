using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace DiscBag
{
    internal class UserClass //class for user that cointains UserID and password
    {
        public string UserId;
        public string Password;

        public UserClass(string userId, string password) //constructor to create objects as userclass.
        {
            UserId = userId;
            Password = password;
        }

        static public List<string> userNames = new List<string>(); //defining a dictionary for users.
        static public List<string> passwords = new List<string>();

        public static void AddUser() //method for adding user, takes userinputs, creates an object as a user and puts it into the dictionary
        {
            Console.WriteLine("\nPlease enter username");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            UserClass user = new UserClass(userName, password);
            userNames.Add(user.UserId);
            passwords.Add(user.Password);
        }

        public static void PrintUser() //method for printing users.
        {
            foreach (string user in userNames)
            {
                Console.WriteLine(user);
            }
                
        }

        public override string ToString() //To-string override for printing
        {
            return $"{userNames}";
        }

    }
}