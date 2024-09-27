using System;
using System.Collections.Generic;

namespace DiscBag
{
    internal class DiscGolfBag
    {
        //Dictionary for storage of Disc-objects.
        static Dictionary<string, Disc> golfBag = new Dictionary<string, Disc>();  

        internal static void AddToBag(Disc addedDisc)
        {
            //function that adds disc-object to the list. Is called from "AddDisc"-function in Disc-class.
            golfBag.Add(addedDisc.name, addedDisc);
        }

        public static void RemoveDisc()
        {   //Function that removs a disc from the dictionary by using the key typed in by the user.
            Console.WriteLine("Please enter the name of the disc you wanna remove");
            string removedDisc = Console.ReadLine();
            Console.WriteLine($"Following disc has been removed {removedDisc}");
            golfBag.Remove(removedDisc);

            //Lägg till sökfunktion för att säkerställa att en disc tas bort!
        }

        public static void PrintBag()
        {
            //foreach-loop that prints the disc-objects in the dictionary
            foreach (var disc in golfBag)
            {
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
                //menu for pressable-keys in switch
                Console.WriteLine("Please choose from the list below\n" +
                    "1. Add disc to your bag.\n" +
                    "2. Remove disc from your bag. \n" +
                    "3. Clear all discs from bag. \n" +
                    "4. Print out bag\n" +
                    "Esc. To close program.");

                // switch-case that uses Console.Readkey to manage a menu of functions
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Disc.AddDisc();
                        break;

                    case ConsoleKey.D2:
                        RemoveDisc();
                        break;

                    case ConsoleKey.D3:
                        ClearBag();
                        break;

                    case ConsoleKey.D4:
                        PrintBag();
                        break;

                    //closes the program with return keyword
                    case ConsoleKey.Escape:
                        return;


                }
            }
        }
    }
}