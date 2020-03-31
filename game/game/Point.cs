using System;
using System.Collections.Generic;
using System.Text;

namespace game
{

    // Define all the points on the map
    class Point
    { 
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y) 
        {
            X = x;
            Y = y; 
        }

        // Calculate distance between a point and the x and y values passed in
        public int DistanceTo(int x, int y) 
        {
            // Cartesian distance formula 
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            // Truncate the decimal since we will only be using ints in our game
            // (int) casts Mat.Sqrt() from a decimal to an int 
            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            // This is harder to read even though it will return same value 
            // return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

        }

        // Calcualte the distance between 2 point objects
        public int DistanceTo(Point point) 
        {

            return DistanceTo(point.X, point.Y);
        
        }


    }
}
