using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class MapLocation : Point
    {
        // Must pass information to the Point constructor. 
        // Simply creating a kind of point.
        // Any map locaiton object will also be a point object 
        // becuse of the use of base.
        public MapLocation(int x, int y) : base(x, y) 
        {
        
        
        }

    }
}
