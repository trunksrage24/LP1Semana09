using System;

namespace Polimorfismo
{
    public class Bee : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzzzz";
        }
    }
}
