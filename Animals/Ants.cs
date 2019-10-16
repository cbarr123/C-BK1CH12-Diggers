using System;

namespace diggers
{
    public class Ants : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The ants are walking");
        }
        public void Dig()
        {
            Console.WriteLine("The ants are digging");
        }
    }
}