using System;

namespace diggers
{
    public class Gerbil : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The gerbil is walking");
        }
        public void Dig()
        {
            Console.WriteLine("The gerbil is digging");
        }
    }
}