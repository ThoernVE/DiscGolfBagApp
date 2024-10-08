using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization;

namespace DiscBag
{
    internal class DiscGolfBag : LogIn
    {

        //Dictionary for storage of Disc-objects.
        public static Dictionary<int, Disc> golfBag = new Dictionary<int, Disc>();
        public static List<Disc> discList = new List<Disc>();

        internal static void AddToBag(Disc addedDisc)
        {
            //function that adds disc-object to the list. Is called from "AddDisc"-function in Disc-class.
            golfBag.Add(golfBag.Count +1, addedDisc);
        }

        public static void RemoveDisc()
        {   //Function that removs a disc from the dictionary by using the key typed in by the user.
            PrintBag();
            Console.WriteLine("\nPlease enter the number of the disc you wanna remove");
            int removedDisc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n Following disc has been removed {golfBag[removedDisc]}");
            golfBag.Remove(removedDisc);

            //Lägg till sökfunktion för att säkerställa att en disc tas bort!
        }

        public static void PrintBag()
        {
            //foreach-loop that prints the disc-objects in the dictionary
            foreach (var disc in golfBag)
            {
                Console.WriteLine("");
                Console.WriteLine(disc);
            }
        }

        public static void ClearBag()
        {
            //using dictionary.Clear()-method to clear the dictionary
            golfBag.Clear();
        }

        public static void GolfBagMenu()
        {
            Console.WriteLine("Hello and Welcome to DiscBag! What would you like to do today?");

            //while-loop to keep the program running until Esc-button is pressed by using return-method in switch
            while (true)
            {
                Console.Clear();
                //menu for pressable-keys in switch
                Console.WriteLine("Please choose from the list below\n" +
                    "1. Add disc to your bag.\n" +
                    "2. Remove disc from your bag. \n" +
                    "3. Clear all discs from bag. \n" +
                    "4. Print out bag\n" +
                    "Esc. To close program.\n");

                // switch-case that uses Console.Readkey to manage a menu of functions
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Disc.AddDisc();
                        Cleanup();
                        break;

                    case ConsoleKey.D2:
                        RemoveDisc();
                        Cleanup();
                        break;

                    case ConsoleKey.D3:
                        ClearBag();
                        Cleanup();
                        break;

                    case ConsoleKey.D4:
                        PrintBag();
                        Cleanup();
                        break;

                    //closes the program with return keyword
                    case ConsoleKey.Escape:
                        return;


                }
            }
        }

        public static void Cleanup()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void SaveData()
        {

            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(golfBag);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(serializedObject);

            }
        }


        public static void LoadData()
        {
            try
            {
                string content = null;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    content = sr.ReadToEnd();
                }


                Dictionary<int, Disc> loadedBag = JsonConvert.DeserializeObject<Dictionary<int, Disc>>(content);

                foreach (var disc in loadedBag)
                {
                    golfBag.Add(disc.Key, disc.Value);
                }
            }
            catch
            {
            }


        }

    }
}
