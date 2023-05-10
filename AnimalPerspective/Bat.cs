using System;

namespace AnimalPerspective
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Ti Ti Ti Ti";
        }
        public int NumberOfWings { get; }
        public int NumberOfNipples { get; }
        public Bat()
        {
            NumberOfWings = 2; // Bats have 2 wings
            NumberOfNipples = 2; // Assuming bats have 2 nipples
        }
    }
}
