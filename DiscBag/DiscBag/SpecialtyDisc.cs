using System;

namespace DiscBag
{
    internal class SpecialtyDisc : Disc
    {
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