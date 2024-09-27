using System;
using System.Collections.Generic;

namespace DiscBag
{
    internal class DiscGolfBag
    {
        static Dictionary<string, Disc> golfBag = new Dictionary<string, Disc>();

        internal static void AddToBag(Disc addedDisc)
        {
            golfBag.Add(addedDisc.name, addedDisc);
        }

        public static void RemoveDisc()
        {   //lägg till sökfunktion för att säkerställa!!
            Console.WriteLine("Please enter the name of the disc you wanna remove");
            string removedDisc = Console.ReadLine();
            Console.WriteLine($"Following disc has been removed {removedDisc}");
            golfBag.Remove(removedDisc);
        }

        public static void PrintBag()
        {
            foreach (var disc in golfBag)
            {
                Console.WriteLine(disc);
            }
        }

        public static void ClearBag()
        {
            golfBag.Clear();
        }

        public static void GolfBagMenu()
        {
            Console.WriteLine("Hello and Welcome to DiscBag! What would you like to do today?");

            while (true)
            {
                Console.WriteLine("Please choose from the list below\n" +
                    "1. Add disc to your bag.\n" +
                    "2. Remove disc from your bag. \n" +
                    "3. Clear all discs from bag. \n" +
                    "4. Print out bag");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Disc.AddDisc();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}