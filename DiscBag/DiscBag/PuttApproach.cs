using System;
using System.Xml.Linq;

namespace DiscBag
{
    internal class PuttApproach : Disc //subclass for Putt & Approach Discs that inherits from parentclass disc.
    {
        //Constructor that creates a PuttApproach-object
        public PuttApproach(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }


        ////function for adding a PuttApproach Disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        internal static void AddPuttApproach(string brand, string name,
                string colour, int speed,
                int glide, int turn,
                 int fade)
        {
            PuttApproach puttApproach = new PuttApproach(brand, name,
                colour, speed,
                glide, turn,
                 fade);
            Console.WriteLine($"\nThe following Putt & Approach disc has been added {puttApproach}");
            DiscGolfBag.AddToBag(puttApproach);
        }
    }
}