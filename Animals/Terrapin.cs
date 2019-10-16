using System;
namespace diggers
{
    public class Terrapin : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The terrapin is walking");
        }
        public void Dig()
        {
            Console.WriteLine("The terrapin is digging");
        }
    }
}