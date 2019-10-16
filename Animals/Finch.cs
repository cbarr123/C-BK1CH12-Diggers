using System;
namespace diggers
{
    public class Finch : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("The finch is flying");
        }
        public int MaximumHeight{get;} = 80;
    }
}