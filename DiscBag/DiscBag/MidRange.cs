using System;

namespace DiscBag
{
    internal class MidRange : Disc //subclass for Midrange Discs that inherits from parentclass disc.
    {
        //Construtor that makes a MidRange-object
        public MidRange(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }

        ////function for adding a MidRange-disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        internal static void AddMidRange(string brand, string name,
            string colour, int speed,
            int glide, int turn, int fade)
        {
            MidRange midRange = new MidRange(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"\nThe following Midrange-disc has been added {midRange}");
            DiscGolfBag.AddToBag(midRange);
        }
    }
}