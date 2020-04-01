using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            // Point parnet class MapLocation child class 
            Point x = new MapLocation(4, 2);

            Point p = x;

            // Generic MapLocaiton object passed to map method 
            map.OnMap(new MapLocation(1, 1));

            // MapLocaiton objects calls point method
            Console.WriteLine(x.DistanceTo(5, 5));

            // See if MapLocation x is a MapLocaiton and Point
            // It is because its a child 
            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);

            // Ses if Point point is MapLocation
            Point point = new Point(0, 0);

            // It isn't because its a paren 
            Console.WriteLine(point is MapLocation);

            Console.WriteLine("Hello, whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + "!");
            Console.ReadLine();

        }
    }
}
