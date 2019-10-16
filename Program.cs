using System;

namespace diggers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Creating flying things
            Finch Freddy = new Finch();
            Parakeet Petey = new Parakeet();

            //Creating AirContainer and adding flying things
            AirContainer AirContainer1 = new AirContainer();
            AirContainer1.FlyingCritters.Add(Freddy);
            AirContainer1.FlyingCritters.Add(Petey);

            //Create digging things
            Ants Antoine = new Ants();
            Earthworm Earl = new Earthworm();
            Mice Mickey = new Mice();
            Terrapin Tony = new Terrapin();
            Console.WriteLine();
            Console.WriteLine("Flying Critters");

            foreach (var critter in AirContainer1.FlyingCritters)
            {
                Console.WriteLine(critter);
            }

            //Create UnderGround Container
            UndergroundContainer UndergroundContainer1 = new UndergroundContainer();
            UndergroundContainer1.DiggingCritters.Add(Antoine);
            UndergroundContainer1.DiggingCritters.Add(Earl);
            UndergroundContainer1.DiggingCritters.Add(Mickey);
            UndergroundContainer1.DiggingCritters.Add(Tony);
            Console.WriteLine();
            Console.WriteLine("Digging Critters");

            foreach (var critter in UndergroundContainer1.DiggingCritters)
            {
                Console.WriteLine(critter);
            }

            //Create Surface Critters
            Ants Anderson = new Ants();
            CopperHead Crawly = new CopperHead();
            Gerbil Gerry = new Gerbil();
            Mice Minnie = new Mice();
            Rattlesnake Randy = new Rattlesnake();
            Terrapin Tracey = new Terrapin();

            //Create Surface Container
            SurfaceContainer SurfaceContainer1 = new SurfaceContainer();
            SurfaceContainer1.WalkingCritters.Add(Anderson);
            SurfaceContainer1.WalkingCritters.Add(Crawly);
            SurfaceContainer1.WalkingCritters.Add(Gerry);
            SurfaceContainer1.WalkingCritters.Add(Minnie);
            SurfaceContainer1.WalkingCritters.Add(Randy);
            SurfaceContainer1.WalkingCritters.Add(Tracey);
            Console.WriteLine();
            Console.WriteLine("Walking Critters");

            foreach (var critter in SurfaceContainer1.WalkingCritters)
            {
                Console.WriteLine(critter);
            }

            //Create Swimming Critters
            BettaFish Bobby = new BettaFish();

            //Create Water Container
            WaterContainer WaterContainer1 = new WaterContainer();
            WaterContainer1.SwimmingCritters.Add(Bobby);
            Console.WriteLine();
            Console.WriteLine("Swimming Critters");

            foreach(var critter in WaterContainer1.SwimmingCritters)
            {
                Console.WriteLine(critter);
            }

        }
    }
}
