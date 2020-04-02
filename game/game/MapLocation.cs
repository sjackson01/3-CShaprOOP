using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class MapLocation : Point
    {
        // Constructor validate if point is on the map
        // Give constructor instance of the map object
        // This is done so we can check if map object is indeed on the map
        public MapLocation(int x, int y, Map map) : base(x, y) 
        {
            // We want to do something if false so we use !
            // If not on the map
            if (!map.OnMap(this)) 
            {   
                // Throw an exception 
                throw new System.Exception();
            
            }
        
        }

    }
}
