using System;

namespace DiscBag
{
    internal class FairwayDriver : Disc //subclass for Fairway Driver Discs that inherits from parentclass disc.
    {
        //Construtor that makes a FairwayDriver-object
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

        ////function for adding a Fairway Driver Disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        internal static void AddFairwayDriver(string brand, string name, 
            string colour, int speed, 
            int glide, int turn, int fade)
        {
            FairwayDriver fairwayDriver = new FairwayDriver(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"\nThe following Fairway driver-disc has been added {fairwayDriver}");
            DiscGolfBag.AddToBag(fairwayDriver);
        }
    }
}