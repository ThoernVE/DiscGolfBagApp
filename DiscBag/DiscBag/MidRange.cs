using System;

namespace DiscBag
{
    internal class MidRange : Disc
    {
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

        internal static void AddMidRange(string brand, string name,
            string colour, int speed,
            int glide, int turn, int fade)
        {
            MidRange midRange = new MidRange(brand, name,
                colour, speed,
                glide, turn,
                fade);
            Console.WriteLine($"The following Midrange-disc has been added {midRange}");
            DiscGolfBag.AddToBag(midRange);
        }
    }
}