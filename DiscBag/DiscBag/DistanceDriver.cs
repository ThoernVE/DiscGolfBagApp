using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    public class DistanceDriver : Disc //subclass for Distance Driver Discs that inherits from parentclass disc.
    {
        //Construtor for adding a DistanceDriver-object
        public DistanceDriver(string brand, string name, string colour, int speed, int glide, int turn, int fade)
        {
            this.brand = brand;
            this.name = name;
            this.colour = colour;
            this.speed = speed;
            this.glide = glide;
            this.turn = turn;
            this.fade = fade;
        }

        ////function for adding a Distance Driver Disc. Takes values from the TypeDiscSwitch in Discs to get userinputs.
        //Then prints the disc that has been added and adds it to the Dictionary through the DiscGolfBag-class.
        public static void AddDistanceDriver(string brand, string name, string colour,
            int speed, int glide, int turn, int fade)
        {
            DistanceDriver distanceDriver = new DistanceDriver(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"\nThe following Distance driver-disc has been added {distanceDriver}");
            DiscGolfBag.AddToBag(distanceDriver);
        }

    }
}
