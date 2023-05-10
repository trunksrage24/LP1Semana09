using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
        public int NumberOfNipples { get; }
        public Dog()
        {
            NumberOfNipples = 8; // Assuming dogs have 8 nipples
        }
    }
}
