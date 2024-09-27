using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    public class Disc
    {
        public string brand { get; set; }
        public string name { get; set; }
        public string colour { get; set; }

        public int speed { get; set; }
        public int glide { get; set; }
        public int turn { get; set; }
        public int fade { get; set; }


        public override string ToString()
        {
            return $"Brand: {brand}, Name: {name}, Colour: {colour}, Stats: {speed}, {glide}, {turn}, {fade}";
        }

        public static void AddDisc()
        {
            Console.WriteLine("Please add the following of the disc you would like to add:\n" +
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

        private static int GetFade()
        {
            try
            {
                int fade = Convert.ToInt32(Console.ReadLine());
                int lowestFade = 0;
                int highestFade = 5;
                CheckStats(fade, lowestFade, highestFade);
                return fade;
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetFade();
            }
        }

        private static int GetTurn()
        {
            try
            {
                int turn = Convert.ToInt32(Console.ReadLine());
                int lowestTurn = -5;
                int highestTurn = 1;
                CheckStats(turn, lowestTurn, highestTurn);
                return turn;
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetTurn();
            }
        }

        private static int GetGlide()
        {
            try
            {
                int glide = Convert.ToInt32(Console.ReadLine());
                int lowestGlide = 1;
                int highestGlide = 7;
                CheckStats(glide, lowestGlide, highestGlide);
                return glide;
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return GetGlide();
            }
        }

        private static int GetSpeed()
        {
            try
            {
                int speed = Convert.ToInt32(Console.ReadLine());
                int lowestSpeed = 1;
                int highestSpeed = 14;
                CheckStats(speed, lowestSpeed, highestSpeed);
                return speed;
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please write a number");
                return GetSpeed();
            }


        }

        private static int CheckStats(int stat, int boundaryOne, int boundaryTwo)
        {
            try
            {
                if (stat >= boundaryOne && stat <= boundaryTwo)
                {
                    return stat;
                }
                else
                {
                    Console.WriteLine("That number was incorrect. Please try again");
                    return CheckStats(Convert.ToInt32(Console.ReadLine()), boundaryOne, boundaryTwo);
                }
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                return CheckStats(Convert.ToInt32(Console.ReadLine()), boundaryOne, boundaryTwo);
            }
        }


        public static void TypeDiscSwitch(string brand, string name,
            string colour, int speed,
            int glide, int turn, int fade)
        {
            try
            {
                Console.WriteLine("Please type the correspondning number for the type of disc\n" +
                "1. Distance Driver?\n" +
                "2. Fairway Driver?\n" +
                "3. Mid-range\n" +
                "4. Putt & Approach\n" +
                "5. Limited Edition\n" +
                "6. Specialty disc");
                int typeOfDisc = Convert.ToInt32(Console.ReadLine());



                switch (typeOfDisc)
                {
                    case 1:
                        DistanceDriver.AddDistanceDriver(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case 2:
                        FairwayDriver.AddFairwayDriver(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case 3:
                        MidRange.AddMidRange(brand, name,
                            colour, speed,
                            glide, turn, fade);
                        break;

                    case 4:
                        PuttApproach.AddPuttApproach(brand, name, colour, speed, glide, turn, fade);
                        break;

                    case 5:
                        LimitedEdition.AddLimitedDisc(brand, name, colour, speed, glide, turn, fade);
                        break;

                    case 6:
                        SpecialtyDisc.AddSpecialtyDisc(brand, name, colour, speed, glide, turn, fade);
                        break;

                    default:
                        Console.WriteLine("This number was not correct. Please try again.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("The input was not correct. Please enter a number.");
                TypeDiscSwitch(brand, name, colour, speed, glide, turn, fade);
            }
        }
    }
}
