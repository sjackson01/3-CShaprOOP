using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Map
    {
        // Readonly: values cannot be changed after object is constructed.
        // We don't want our map size to change. 
        public readonly int Width;  
        public readonly int Height;  

        // Create constructor 
        // Intialize the objects fields with initial values. 
        public Map(int width, int height)
        {
            // Use parameters to set fields.
            Width = width;
            Height = height; 

        }


        // Is the point on the map
        // x >= 0 of x < 8
        // y >= 0 or Y < 5 
        public bool OnMap(Point point) 
        {
            // Simple way of checking 
            bool inBounds = point.X >= 0 
                            && point.X < Width
                            && point.Y >= 0
                            && point.Y < Height;

            /* Check if out of bounds example 
            bool outOfBounds = point.X < 0 
                            || point.X >= Width 
                            || point.Y < 0 
                            || point.Y >= Height;

            
            inBounds = !outOfBounds; 
            */


            return inBounds; 
        }
    }
}
