using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DiscBag
{
    internal class LogIn
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string filePath = Path.Combine(path, "saveFile.json");

        internal static void Start()
        {
            Console.WriteLine("What would you like to do today\n" +
                "1. Login\n" +
                "2. Create a new user\n" +
                "Available users:");
            UserClass.PrintUser();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    LogInMethod();
                    break;

                case ConsoleKey.D2:
                    UserClass.AddUser();
                    Start();
                    SaveLogInData();
                    DiscGolfBag.Cleanup();
                    break;
            }

        }

        private static void LogInMethod()
        {
            Console.WriteLine("\nPlease enter your username");
            string attemptedUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string attemptedPassword = Console.ReadLine();
            UserClass.CheckUser(attemptedUsername, attemptedPassword);
            DiscGolfBag.LoadData();
        }

        public static void SaveLogInData()
        {

            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(UserClass.users);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "saveFileUsers.json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(serializedObject);

            }
        }


        public static void LoadLoginData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "saveFileUsers.json");

            try
            {
                string content = null;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    content = sr.ReadToEnd();
                }


                Dictionary<string, string> loadedUsers = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                foreach (var user in loadedUsers)
                {
                    UserClass.users.Add(user.Key, user.Value);
                }
            }
            catch 
            {
            }


        }

    }
}