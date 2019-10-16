using System;

namespace diggers
{
    public class Earthworm : IDigging, ISlithering
    {
        public void Dig()
        {
            Console.WriteLine("The earthworm digs");
        }
        public void Slither()
        {
            Console.WriteLine("The earthworm slithers");
        }
    }
}