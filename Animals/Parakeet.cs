using System;
namespace diggers
{
    public class Parakeet : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("The parakeet is flying");
        }
        public int MaximumHeight{get;} = 100;
    }
}