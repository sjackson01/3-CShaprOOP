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
                MapLocation mapLocation = new MapLocation(20, 20, map);
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
