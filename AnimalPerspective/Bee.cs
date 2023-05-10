using System;

namespace AnimalPerspective
{
    public class Bee : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzzzz";
        }
    }
}
