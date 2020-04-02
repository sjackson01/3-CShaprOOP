using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create map location we know isn't on the map
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception) 
            {
                Console.WriteLine("That map locaiton is not on the map");
            }
        }
    }
}
