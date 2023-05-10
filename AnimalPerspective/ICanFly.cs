using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public interface ICanFly
    {
        int NumberOfWings { get; }
    }
    public class Bat : ICanFly
    {
        public int NumberOfWings { get; }
        public Bat()
        {
            NumberOfWings = 2; // Bats have 2 wings
        }
    }
    
    public class Bee : ICanFly
    {
        public int NumberOfWings { get; }
        public Bee()
        {
            NumberOfWings = 4; // Bees have 4 wings
        }
    }
}