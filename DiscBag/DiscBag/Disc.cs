using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    public class Disc //Parentclass for all discs
    {
        //adding all varriables that exists for all discs.
        public string brand { get; set; }
        public string name { get; set; }
        public string colour { get; set; }

        public int speed { get; set; }
        public int glide { get; set; }
        public int turn { get; set; }
        public int fade { get; set; }


        public override string ToString() //ToString override method to use for correct printing of the discinformation
        {
            return $"Brand: {brand}, Name: {name}, Colour: {colour}, Stats: {speed}, {glide}, {turn}, {fade}";
        }

        public static void AddDisc() //Function that collects userinputs and sends that information to TypeDiscSwitch-function.
            //Uses functions in order to collect data and verify it for speed, glide and turn.
        {
            Console.WriteLine("\nPlease add the following of the disc you would like to add:\n" +
            "Brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Colour");
            string colour = Console.ReadLine();
            Console.WriteLine("Speed, between 1 - 14");
            int speed = GetSpeed();
            Console.WriteLine("Glide, between 1 - 7");
            int glide = GetGlide();
            Console.WriteLine("Turn, between -5 - 1");
            int turn = GetTurn();
            Console.WriteLine("Fade, between 0 - 5");
            int fade = GetFade();

            TypeDiscSwitch(brand, name, colour, speed, glide, turn, fade);

        }


        private static int GetFade() //function for collecting and verifying the input for Fade.
                                     //Defines highest and lowest values and sends them to CheckStats()-function to check input.
                                     //If it input is correct, method returns the input.
        {
            try //try-catch to make sure the input is a number
            {
                int fade = Convert.ToInt32(Console.ReadLine());
                int lowestFade = 0;
                int highestFade = 5;
                CheckStats(fade, lowestFade, highestFade);
                return fade;
            }
            catch //catch prints errormessage and returns function again.
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetFade();
            }
        }

        private static int GetTurn() //function for collecting and verifying the input for Turn.
                                     //Defines highest and lowest values and sends them to CheckStats()-function to check input.
                                     //If it input is correct, method returns the input.
        {
            try //try-catch to make sure input is a number
            {
                int turn = Convert.ToInt32(Console.ReadLine());
                int lowestTurn = -5;
                int highestTurn = 1;
                CheckStats(turn, lowestTurn, highestTurn);
                return turn;
            }
            catch //catch prints errormessage and returns function again
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetTurn();
            }
        }

        private static int GetGlide() //function for collecting and verifying the input for Glide.
                                      //Defines highest and lowest values and sends them to CheckStats()-function to check input.
                                      //If it input is correct, method returns the input.
        {
            try //try-catch to make sure input is a number
            {
                int glide = Convert.ToInt32(Console.ReadLine());
                int lowestGlide = 1;
                int highestGlide = 7;
                CheckStats(glide, lowestGlide, highestGlide);
                return glide;
            }
            catch //catch prints errormessage and returns function
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetGlide();
            }
        }

        private static int GetSpeed() //function for collecting and verifying the input for Speed.
                                      //Defines highest and lowest values and sends them to CheckStats()-function to check input.
                                      //If it input is correct, method returns the input.
        {
            try //try-catch to make sure input is a number
            {
                int speed = Convert.ToInt32(Console.ReadLine());
                int lowestSpeed = 1;
                int highestSpeed = 14;
                CheckStats(speed, lowestSpeed, highestSpeed);
                return speed;
            } 
            catch //catch prints errormessage and returns function
            {
                Console.WriteLine("The input was not correct. Please write a number");
                return GetSpeed();
            }


        }

        private static int CheckStats(int stat, int boundaryOne, int boundaryTwo) 
            //Function that checks the input compared to the boundaries set in variables.
            //If correct, it returns the input, otherwise it returns the function again with a new userinput.
        {
            try //try catch to make sure input is number
            {
                if (stat >= boundaryOne && stat <= boundaryTwo) //if-statement that checks the number so its between or the same as highest and lowest.
                                                                //Returns the inserted input if correct.
                {
                    return stat;
                }
                else //Else- that takes inputs outside of the boundaries, prints errormessage and returns function again with a new userinput.
                { 
                    Console.WriteLine("That number was incorrect. Please try again");
                    return CheckStats(Convert.ToInt32(Console.ReadLine()), boundaryOne, boundaryTwo);
                }
            }
            catch //catch prints errormessage and returns function with another userinput
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return CheckStats(Convert.ToInt32(Console.ReadLine()), boundaryOne, boundaryTwo);
            }
        }


        public static void TypeDiscSwitch(string brand, string name,
            string colour, int speed,
            int glide, int turn, int fade)
            //function for a switch that lets the user choose what type of disc that should be added.
        {
            try //try to make sure the input is valid for switch
            {
                Console.WriteLine("Please type the correspondning number for the type of disc\n" +
                "1. Distance Driver?\n" +
                "2. Fairway Driver?\n" +
                "3. Mid-range\n" +
                "4. Putt & Approach\n" +
                "5. Limited Edition\n" +
                "6. Specialty disc");
                

                //switch console that uses Console.ReadKey().Key-method to add the type of disc the user wants.
                //Calls the new function that creates the specific disc with acquired parameters from input.
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        DistanceDriver.AddDistanceDriver(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case ConsoleKey.D2:
                        FairwayDriver.AddFairwayDriver(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case ConsoleKey.D3:
                        MidRange.AddMidRange(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case ConsoleKey.D4:
                        PuttApproach.AddPuttApproach(brand, name, colour, speed, glide, turn, fade);
                        break;

                    case ConsoleKey.D5:
                        LimitedEdition.AddLimitedDisc(brand, name, colour, speed, glide, turn, fade);
                        break;

                    case ConsoleKey.D6:
                        SpecialtyDisc.AddSpecialtyDisc(brand, name, colour, speed, glide, turn, fade);
                        break;

                    default:
                        Console.WriteLine("\nThis number was not correct. Please try again.");
                        break;
                }
            }
            catch // catch prints errormessage and calls the function again with the same parameters.
            {
                Console.WriteLine("\nThe input was not correct. Please enter a number.");
                TypeDiscSwitch(brand, name, colour, speed, glide, turn, fade);
            }
        }
    }
}
