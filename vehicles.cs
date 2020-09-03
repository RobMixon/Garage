using System;
using System.Collections.Generic;

namespace garage {
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive () {
            Console.WriteLine ("Vrooom!");
        }

        public virtual void Turn (string Direction) {
            Console.WriteLine ($"The vehicle turns {Direction}");
        }

        public virtual void Stop () {
            Console.WriteLine ("The vehicle stops");
        }
    }
}