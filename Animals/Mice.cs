using System;

namespace diggers
{
    public class Mice : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The mouse is walking");
        }
        public void Dig()
        {
            Console.WriteLine("The mouse is digging");
        }
    }
}