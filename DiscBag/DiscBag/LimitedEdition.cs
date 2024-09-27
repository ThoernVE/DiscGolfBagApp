using System;

namespace DiscBag
{
    internal class LimitedEdition : Disc
    {
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