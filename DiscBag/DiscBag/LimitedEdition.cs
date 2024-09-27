using System;

namespace DiscBag
{
    internal class LimitedEdition : Disc //subclass for limited edition discs that inherit from parentclass Disc.
    {
        //constructor for creating a limitedEdition Disc
        public LimitedEdition(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }

        //function for adding a Limited Edition Disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        internal static void AddLimitedDisc(string brand, string name,
                string colour, int speed,
                int glide, int turn,
                 int fade)
        {
            LimitedEdition limitedEdition = new LimitedEdition(brand, name,
                colour, speed,
                glide, turn,
                 fade);
            Console.WriteLine($"The following Limited Edition-disc has been added {limitedEdition}");
            DiscGolfBag.AddToBag(limitedEdition);
        }
    }
}