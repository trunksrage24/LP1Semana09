using System;

namespace AnimalPerspective
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a0 = new Animal ( ) ;
            Animal a1 = new Dog ( ) ;
            Animal a2 = new Cat ( ) ;
            Console.WriteLine(a0.Sound()); // " Animal makes sound "
            Console.WriteLine(a1.Sound()); // "Woof ! "
            Console.WriteLine(a2.Sound()); // "Miau " (por exemplo)
        }
    }
}
