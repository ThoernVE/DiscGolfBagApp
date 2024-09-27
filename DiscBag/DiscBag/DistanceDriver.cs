using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    public class DistanceDriver : Disc
    {
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

        public static void AddDistanceDriver(string brand, string name, string colour,
            int speed, int glide, int turn, int fade)
        {
            DistanceDriver distanceDriver = new DistanceDriver(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"The following Distance driver-disc has been added {distanceDriver}");
            DiscGolfBag.AddToBag(distanceDriver);
        }

    }
}
