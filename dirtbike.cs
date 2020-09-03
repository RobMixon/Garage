using System;
using System.Collections.Generic;

namespace garage {
    public class dirtbike : Vehicle, IGasVehicle {
        public double FuelCapacity { get; set; }
        public int TankPercentage { get; set; }

        public void RefuelTank () {
            TankPercentage = 39;
        }

        public override void Drive () {
            Console.WriteLine ("The dirtbike goes braaaapppp!");
        }

        public override void Stop () {
            Console.WriteLine ("Dirtbikes cant stop, wont stop, dont stop! braaaap!");
        }
    }
}