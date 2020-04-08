using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create map location we know isn't on the map
            Map map = new Map(8, 5);


            // When using multiple catch clauses place more specific types first 
            try
            {
                MapLocation[] path = {
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map),
                };
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex);
            }
            catch (TreeHouseDefenseException) 
            {
                Console.WriteLine("Unhandled tree house defense exception.");
            }
            // Create exception object to access the messeage in ex 
            catch (Exception)
            {
                Console.WriteLine("Unhandled tree house defense exception.");
            }
        }
    }
}
