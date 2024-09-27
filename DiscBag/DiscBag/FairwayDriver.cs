using System;

namespace DiscBag
{
    internal class FairwayDriver : Disc
    {
        public FairwayDriver(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }

        internal static void AddFairwayDriver(string brand, string name, 
            string colour, int speed, 
            int glide, int turn, int fade)
        {
            FairwayDriver fairwayDriver = new FairwayDriver(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"The following Fairway driver-disc has been added {fairwayDriver}");
            DiscGolfBag.AddToBag(fairwayDriver);
        }
    }
}