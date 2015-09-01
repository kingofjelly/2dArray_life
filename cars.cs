using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dArray
{
    public class cars
    {
        //class for cars.

        /*1. Create base class w/ wheelNo, color, make
         *2. Create child class, adding in spoiler?
         *3. Create method in Program.cs, which creates an array of classes? containg their attributes. Try then to access
         *   an array element and print an attribute
         *   
         * //you don't set the variables directly. You call a method whcih does it for you.
         * 
         *
         */

        public string Make { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public cars(string make, string name, string color)
        {
            //this is called from below, or whatever will be calling this. Lets assuming Program.CS
            Make = make;
            Name = name;
            Color = color;
        }
    }

   
}
