using System;

namespace DiscBag
{
    internal class SpecialtyDisc : Disc //subclass for Specialty Discs that inherits from parentclass disc.
    {
        //constructor that creates a SpecialtyDisc-object.
        public SpecialtyDisc(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }

        //function for adding a Specialty Disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        internal static void AddSpecialtyDisc(string brand, string name,
            string colour, int speed,
            int glide, int turn, int fade)
        {
            SpecialtyDisc specialtyDisc = new SpecialtyDisc(brand, name,
                colour, speed,
                glide, turn,
                 fade);
            Console.WriteLine($"The following Limited Edition-disc has been added {specialtyDisc}");
            DiscGolfBag.AddToBag(specialtyDisc);
        }
    }
}