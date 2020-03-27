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
    }
}
