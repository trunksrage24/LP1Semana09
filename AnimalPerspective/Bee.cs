using System;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzzzz";
        }
        public int NumberOfWings { get; }
        public Bee()
        {
            NumberOfWings = 4; // Bees have 4 wings
        }
    }
}
