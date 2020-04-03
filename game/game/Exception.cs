using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    // Exceptions must inherit from System.Exception
    class TreeHouseDefenseException : System.Exception
    {
        // Constructor that doesn't have to show a message
        // Both types important
        public TreeHouseDefenseException() 
        { 
        
        
        }

        // Forward the base class constructor with message  
        // Consnstructor that must show a message
        public TreeHouseDefenseException(string message) : base(message)
        { 
        
        
        }

    }

    class OutOfBoundsException : TreeHouseDefenseException
    {
        // Constructor that doesn't have to show a message
        // Both types important
        // Default constructors doen't need to have the base()
        // Default construcotrs automatically call constructor of base class
        public OutOfBoundsException() 
        { 
        
        
        }


        // Forward the base class constructor again with message  
        public OutOfBoundsException(string message) : base(message) 
        { 
        
        
        
        }
    
    
    }



}
