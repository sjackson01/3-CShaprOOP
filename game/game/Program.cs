using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            // Create point
            Point point = new Point(4, 2);

            // Check if point is on map 
            bool isOnMap = map.OnMap(point);

            Console.WriteLine(isOnMap);

            point = new Point(8, 5);
            isOnMap = map.OnMap(point);

            Console.WriteLine(isOnMap);
        }
    }
}
