using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public interface IMammal
    {
        int NumberOfNipples { get; }
    }
 
    public class Dog : IMammal
    {
        public int NumberOfNipples { get; }
        public Dog()
        {
            NumberOfNipples = 8; // Assuming dogs have 8 nipples
        }
    }

    public class Cat : IMammal
    {
        public int NumberOfNipples { get; }
        public Cat()
        {
            NumberOfNipples = 6; // Assuming cats have 6 nipples
        }
    }
}