using System;
using System.Xml.Linq;

namespace DiscBag
{
    internal class PuttApproach : Disc
    {
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

        internal static void AddPuttApproach(string brand, string name,
                string colour, int speed,
                int glide, int turn,
                 int fade)
        {
            PuttApproach puttApproach = new PuttApproach(brand, name,
                colour, speed,
                glide, turn,
                 fade);
            Console.WriteLine($"The following Putt & Approach disc has been added {puttApproach}");
            DiscGolfBag.AddToBag(puttApproach);
        }
    }
}