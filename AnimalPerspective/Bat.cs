using System;

namespace AnimalPerspective
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Ti Ti Ti Ti";
        }
    }
}
