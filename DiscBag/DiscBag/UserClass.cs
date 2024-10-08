using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace DiscBag
{
    internal class UserClass
    {
        public static string UserId;
        public static string Password;

        public UserClass(string userId, string password)
        {
            UserId = userId;
            Password = password;
        }

        static public Dictionary<string, string> users = new Dictionary<string, string>();
        
        public static void AddUser()
        {
            Console.WriteLine("\nPlease enter username");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            UserClass user = new UserClass(userName, password);
            users.Add(userName, password);
        }

        public static void PrintUser()
        {
            foreach (var user in users) 
                Console.WriteLine(user.Key);
        }

       /* public  override string ToString()
        {
            return $"{UserId}";
        }*/


        internal static void CheckUser(string userName, string password)
        {
            foreach (var user in users)
            {
                if (userName == UserId && password == Password)
                {
                    Console.WriteLine("Welcome to the Discbag Application!");
                    LogIn.filePath =  Path.Combine(LogIn.path, $"{userName}saveFile.json");
                    
                }
                else
                {
                    Console.WriteLine("Login-attempt failed");
                    LogIn.Start();
                }
            }
            
        }
    }
}