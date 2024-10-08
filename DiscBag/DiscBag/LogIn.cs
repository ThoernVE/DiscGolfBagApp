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

        internal static void Start() //starting menu, loads data, prints available users and initiates startmenu
        {
            LoadLoginData(); //loads data from local files
            //Console.WriteLine("Available users:");
           // UserClass.PrintUser(); //prints available users.
            StartMenu();
        }

        public static void StartMenu() //menu for navigating login
        {
            Console.WriteLine("What would you like to do today\n" +
                "1. Login\n" +
                "2. Create a new user\n" +
                "Press 'Escape' to close application\n");
            Console.WriteLine("Available users:");
            UserClass.PrintUser(); //prints available users.


            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    LogInMethod();
                    break;

                case ConsoleKey.D2:
                    UserClass.AddUser();
                    SaveLogInData();
                    DiscGolfBag.Cleanup();
                    StartMenu();
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter a valid option");
                    DiscGolfBag.Cleanup();
                    StartMenu();
                    break;
            }
        }

        private static void LogInMethod() //method that takes two userinputs and checks them against the list to make sure both password and usernames are the same as input. Not functioning, needs rework?
        {
            Console.WriteLine("\nPlease enter your username");
            string attemptedUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string attemptedPassword = Console.ReadLine();
            bool existingUser = UserClass.userNames.Contains(attemptedUsername); //checks if the username exists
            if (existingUser == true)
            {
                for (int i = 0; i < UserClass.userNames.Count; i++) //checks every iteration of username and password to make sure both sides match
                {
                    if (attemptedUsername == UserClass.userNames[i] && attemptedPassword == UserClass.passwords[i])
                    {
                        Console.WriteLine("Welcome to the Discbag Application!");
                        LogIn.filePath = Path.Combine(LogIn.path, $"{attemptedUsername}saveFile.json"); //sets filepath to the users specific file
                        break;

                    }
                    else if (attemptedUsername == UserClass.userNames[i] && attemptedPassword != UserClass.passwords[i]) //sends fault message and calls startmenu if password is wrong but username is correct.
                    {
                        Console.WriteLine("Password was wrong. Please try again."); 
                        DiscGolfBag.Cleanup();
                        StartMenu();
                    }
                }
            }
            else //else-statement if the username does not exist.
            {
                Console.WriteLine("User was not found. Please try again");
                DiscGolfBag.Cleanup();
                StartMenu();
            }
            DiscGolfBag.LoadData(); //calling method to load the disc-data for the user.
            
        }


        public static void SaveLogInData() //method for saving logindata, calls methods for usernames and passwords.
        {
            SaveUserNames();
            SavePasswords();
        }

        public static void SaveUserNames()
        {
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(UserClass.userNames); //defines the variable for the list that is being saved and also the place it should be saved.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "saveFileUsers.json");

            using (StreamWriter sw = new StreamWriter(filePath)) //streamwriter that saves the data
            {
                sw.Write(serializedObject);
            }
        }

        public static void SavePasswords() 
        {
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(UserClass.passwords); //defines the variable for the list that is being saved and also the place it should be saved.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "saveFilePasswords.json");

            using (StreamWriter sw = new StreamWriter(filePath)) //streamwriter that saves the data
            {
                sw.Write(serializedObject);
            }
        }   


        public static void LoadLoginData() //method that loads logindata, calls methods for usernames and passwords.
        {
            LoadUserNames();
            LoadPasswords(); 
        }

        public static void LoadUserNames()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //defines from where to read the data
                string filePath = Path.Combine(path, "saveFileUsers.json");

                string content = null;
                using (StreamReader sr = new StreamReader(filePath)) //streamreader that reads data
                {
                    content = sr.ReadToEnd();
                }


                List<string> loadedUsers = JsonConvert.DeserializeObject<List<string>>(content); //creates a list of the read data

                foreach (string user in loadedUsers) //converts the read data from the loading-list to the list that app is using.
                {
                    UserClass.userNames.Add(user);
                }
            }
            catch
            {
            }
        }

        public static void LoadPasswords()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //defines from where to read the data
                string filePath = Path.Combine(path, "saveFilePasswords.json");

                string content = null;
                using (StreamReader sr = new StreamReader(filePath)) //streamreader that reads dat
                {
                    content = sr.ReadToEnd();
                }


                List<string> loadedPasswords = JsonConvert.DeserializeObject<List<string>>(content); //creates a list of the read data

                foreach (string password in loadedPasswords) //converts the read data from the loading-list to the list that app is using.
                {
                    UserClass.passwords.Add(password);
                }
            }
            catch
            {
            }
        }

    }
}